
INSERT INTO Users (FirstName, Surname, IdNumber, Token)
VALUES 
  ('John', 'Doe', '8001015009087', 'abc123xyz456'),
  ('Jane', 'Smith', '8102020012086', 'def456uvw789'),
  ('Bob', 'Johnson', '6803034005082', 'ghi789rst123'),
  ('Mary', 'Jones', '9404043006086', 'jkl012uvw345'),
  ('James', 'Brown', '8305052007083', 'mno345pqr678'),
  ('Linda', 'Williams', '7612067007082', 'stu901vwx234'),
  ('David', 'Lee', '9007075003085', 'yza567bcd890'),
  ('Sarah', 'Taylor', '9208084002081', 'efg234hij567'),
  ('Michael', 'Wilson', '8710093007087', 'klm789nop123'),
  ('Karen', 'Anderson', '8801102003081', 'qrs234tuv567');

INSERT INTO Statuses (StatusName)
VALUES
	('Complete'),
	('In Progress'),
	('Incomplete');
	
INSERT INTO Contacts (Email, CellPhone, UserID)
VALUES 
  ('john.doe@example.com', '0811234567', 1),
  ('jane.smith@example.com', '0822345678', 2),
  ('bob.johnson@example.com', '0833456789', 3),
  ('mary.jones@example.com', '0844567890', 4),
  ('james.brown@example.com', '0855678901', 5),
  ('linda.williams@example.com', '0866789012', 6),
  ('david.lee@example.com', '0877890123', 7),
  ('sarah.taylor@example.com', '0888901234', 8),
  ('michael.wilson@example.com', '0899012345', 9),
  ('karen.anderson@example.com', '0800123456', 10);
 
 
INSERT INTO Addresses (Province, City, StreetName, PostalCode, UserID)
VALUES 
  ('Gauteng', 'Johannesburg', 'Main Street', 2001, 1),
  ('Western Cape', 'Cape Town', 'Church Street', 8001, 2),
  ('KwaZulu-Natal', 'Durban', 'Smith Street', 4001, 3),
  ('Free State', 'Bloemfontein', 'Maitland Street', 9301, 4),
  ('Eastern Cape', 'Port Elizabeth', 'Russell Road', 6001, 5),
  ('Limpopo', 'Polokwane', 'Hans Van Rensburg Street', 0699, 6),
  ('Mpumalanga', 'Nelspruit', 'Mandela Drive', 1200, 7),
  ('North West', 'Mahikeng', 'Albert Luthuli Drive', 2745, 8),
  ('Northern Cape', 'Kimberley', 'Jones Street', 8301, 9),
  ('Gauteng', 'Pretoria', 'Vermeulen Street', 0001, 10);
  
  
INSERT INTO ImageReferences (ImageReference) 
VALUES 
	('https://example.com/images/image1.jpg'),
	('https://example.com/images/image2.jpg'),
	('https://example.com/images/image3.jpg'),
	('https://example.com/images/image4.jpg'),
	('https://example.com/images/image5.jpg'),
	('https://example.com/images/image6.jpg'),
	('https://example.com/images/image7.jpg'),
	('https://example.com/images/image8.jpg'),
	('https://example.com/images/image9.jpg'),
	('https://example.com/images/image10.jpg'); 
	
INSERT INTO JobTypes (JobTypeName, HourlyRate)
VALUES 
   ('Landscaper', 20.00),
   ('Construction Worker', 25.00),
   ('Electrician', 30.00),
   ('Plumber', 30.00),
   ('Farmhand', 15.00),
   ('Community watch', 18.00),
   ('Waste Management Worker', 20.00),
   ('Road Maintenance Worker', 22.00);
 
INSERT INTO JobRequests (JobRequestDescription, UserID, ImageReferenceID, JobTypeID, EstimatedCost) 
VALUES 
	('Installing a fence around a park', 1, 1, 1, 100.00),
	('Neighborhood watch', 2, 2, 2, 150.00),
	('Fixing/closing potholes', 3, 3, 3, 200.00),
	('Cutting grass at the park', 4, 4, 4, 75.00),
	('Ctting of trees in the park', 5, 5, 5, 125.00),
	('Cleaning the neighborhood', 6, 6, 1, 50.00),
	('Cutting grass near a local school', 7, 7, 2, 75.00),
	('Building a library', 8, 8, 3, 250.00),
	('Neighborhood garbage collection', 9, 9, 4, 150.00),
	('Fixing/closing potholes', 10, 10, 5, 200.00);
  
INSERT INTO Donations (Amount, UserID, JobRequestID)
VALUES 
   (150.00, 1, 20),
   (220.00, 2, 19),
   (100.00, 3, 18),
   (400.00, 4, 17),
   (30.00, 5, 16),
   (75.00, 6, 15),
   (150.00, 7, 12),
   (40.00, 8, 11),
   (50.00, 9, 13),
   (325.00, 10, 20);
  
INSERT INTO PublicVotes (UserID, JobRequestID, UpVotes, DownVotes)
VALUES 
   (1, 20, 10, 2),
   (2, 19, 5, 1),
   (3, 18, 8, 0),
   (4, 17, 2, 0),
   (5, 16, 3, 1),
   (6, 15, 7, 3),
   (7, 14, 1, 0),
   (8, 13, 0, 2),
   (9, 12, 4, 0),
   (10, 11, 6, 10);
  
INSERT INTO ApprovedJobs (JobRequestID, UserID, StatusID)
VALUES 
   (11, 1, 1),
   (13, 2, 1),
   (12, 3, 2),
   (14, 4, 2),
   (16, 5, 3),
   (15, 6, 3),
   (17, 7, 3),
   (18, 8, 1),
   (19, 9, 2),
   (20, 10, 3);
   
INSERT INTO JobImageReferences (ApprovedJobID, ImageReferenceID)
VALUES 
   (1, 1),
   (2, 2),
   (3, 3),
   (4, 4),
   (5, 5),
   (6, 6),
   (7, 7),
   (8, 8),
   (9, 9),
   (10, 10);


 