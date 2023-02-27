CREATE TABLE JobTypes (
   JobTypeID SERIAL PRIMARY KEY NOT NULL,
   JobTypeName VARCHAR(120) ,
   HourlyRate MONEY
);


CREATE TABLE Users (
   UserID SERIAL PRIMARY KEY NOT NULL,
   FirstName VARCHAR(120) ,
   Surname VARCHAR(120),
   IdNumber CHAR(13),
   Token VARCHAR(255)
);


CREATE TABLE Contacts (
   ContactID SERIAL PRIMARY KEY NOT NULL,
   Email VARCHAR(120) ,
   CellPhone VARCHAR(20),
   UserID INT,
   FOREIGN KEY (UserID) REFERENCES Users (UserID)
);


CREATE TABLE Addresses (
   AddressID SERIAL PRIMARY KEY NOT NULL,
   Province VARCHAR(50) ,
   City VARCHAR(50),
   StreetName VARCHAR(50),
   PostalCode INT,
   UserID INT,
   FOREIGN KEY (UserID) REFERENCES Users (UserID)
);


CREATE TABLE ImageReferences (
   ImageReferenceID SERIAL PRIMARY KEY NOT NULL,
   ImageReference VARCHAR(120) 
);


CREATE TABLE JobRequests (
   JobRequestID SERIAL PRIMARY KEY NOT NULL,
   JobRequestDescription VARCHAR(50) ,
   UserID INT,
   ImageReferenceID INT,
   JobTypeID INT,
   EstimatedCost MONEY,
   Status BIT DEFAULT cast(0 as bit),
   FOREIGN KEY (UserID) REFERENCES Users (UserID),
   FOREIGN KEY (ImageReferenceID) REFERENCES ImageReferences (ImageReferenceID),
   FOREIGN KEY (JobTypeID) REFERENCES JobTypes (JobTypeID)
);


CREATE TABLE Donations (
   DonationID SERIAL PRIMARY KEY NOT NULL,
   Amount MONEY,
   UserID INT,
   JobRequestID INT,
   FOREIGN KEY (JobRequestID) REFERENCES JobRequests (JobRequestID),
   FOREIGN KEY (UserID) REFERENCES Users (UserID)
);



CREATE TABLE PublicVotes (
   PublicVoteID SERIAL PRIMARY KEY NOT NULL,
   UserID INT,
   JobRequestID INT,
   UpVotes INT DEFAULT 0,
   DownVotes INT DEFAULT 0,
   FOREIGN KEY (JobRequestID) REFERENCES JobRequests (JobRequestID),
   FOREIGN KEY (UserID) REFERENCES Users (UserID)
);


CREATE TABLE Statuses (
   StatusID SERIAL PRIMARY KEY NOT NULL,
   StatusName VARCHAR(120) 
);



CREATE TABLE ApprovedJobs (
   ApprovedJobID SERIAL PRIMARY KEY NOT NULL,
   JobRequestID INT,
   UserID INT,
   StatusID INT,
   FOREIGN KEY (JobRequestID) REFERENCES JobRequests (JobRequestID),
   FOREIGN KEY (UserID) REFERENCES Users (UserID),
   FOREIGN KEY (StatusID) REFERENCES Statuses (StatusID)
);

CREATE TABLE JobImageReferences (
   JobImageReferenceID SERIAL PRIMARY KEY NOT NULL,
   ApprovedJobID INT,
   ImageReferenceID INT,
   FOREIGN KEY (ImageReferenceID) REFERENCES ImageReferences (ImageReferenceID),
   FOREIGN KEY (ApprovedJobID) REFERENCES ApprovedJobs (ApprovedJobID)
   
);

