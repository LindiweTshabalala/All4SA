CREATE VIEW vwJobRequestDetails AS
SELECT u.FirstName, jr.JobRequestID, jr.JobRequestDescription, jt.JobTypeName AS JobType, 
jr.EstimatedCost, ir.ImageReference 
FROM Users u
JOIN JobRequests jr ON u.UserID = jr.UserID
JOIN JobTypes jt ON jr.JobTypeID = jt.JobTypeID
JOIN ImageReferences ir ON jr.ImageReferenceID = ir.ImageReferenceID;



CREATE VIEW vwApprovedJobDetails AS
SELECT a.ApprovedJobID, j.JobRequestDescription, t.JobTypeName, s.StatusName
FROM ApprovedJobs a
JOIN JobRequests j ON a.JobRequestID = j.JobRequestID
JOIN JobTypes t ON j.JobTypeID = t.JobTypeID
JOIN Statuses s ON a.StatusID = s.StatusID;



CREATE VIEW vwUserDetails AS 
SELECT u.UserID, u.FirstName, u.Surname, c.Email, c.CellPhone
FROM Users AS u
INNER JOIN Contacts AS c ON u.UserID = c.UserID;



CREATE VIEW vwPublicVotes AS
SELECT p.PublicVoteID, u.FirstName, u.Surname, p.JobRequestID, p.UpVotes, p.DownVotes
FROM PublicVotes AS p
JOIN Users AS u ON p.UserID = u.UserID;
