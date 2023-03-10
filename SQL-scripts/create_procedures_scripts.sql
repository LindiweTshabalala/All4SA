
CREATE PROCEDURE add_donation_amount(increase_amount MONEY, jobrequestid_ INT)
LANGUAGE plpgsql
AS $$
BEGIN
  UPDATE Donations SET Amount = Amount + increase_amount 
WHERE JobRequestID = jobrequestid_;
END;
$$;

CALL add_donation_amount(CAST(102.69 AS MONEY),1);



CREATE OR REPLACE PROCEDURE sp_add_user_details(
    IN first_name VARCHAR(120),
    IN surname VARCHAR(120),
    IN id_number CHAR(13),
    IN token_ VARCHAR(255),
    IN email VARCHAR(120),
    IN cell_phone VARCHAR(20),
    IN province VARCHAR(50),
    IN city VARCHAR(50),
    IN street_name VARCHAR(50),
    IN postal_code INT
)
LANGUAGE plpgsql
AS $$
DECLARE
    user_id INT;
BEGIN
    INSERT INTO Users (FirstName, Surname, IdNumber, token) 
    VALUES (first_name, surname, id_number, token_) 
    RETURNING UserID INTO user_id;

    INSERT INTO Contacts (Email, CellPhone, UserID) 
    VALUES (email, cell_phone, user_id);

    INSERT INTO Addresses (Province, City, StreetName, PostalCode, UserID)
    VALUES (province, city, street_name, postal_code, user_id);

    EXCEPTION WHEN OTHERS THEN
    RAISE NOTICE 'Error adding user with contact and address: %', SQLERRM;
END;
$$;



call sp_add_user_details('Done', 'Mashaba', '3505230824520','gldfjdfhdsgfjhdgshfdsagldsf','done@yahoo.com',
				 '0736256300','North West', 'Porch','Near Me', 1912 );





CREATE PROCEDURE spInsertJobRequest (
   IN jobRequestDescription VARCHAR(50),
   IN userID INT,
   IN imageReference VARCHAR(120),
   IN jobTypeID INT,
   IN estimatedCost MONEY
)
LANGUAGE plpgsql
AS $$
DECLARE
   imageRefID INT;
BEGIN
   -- Insert the image reference
   INSERT INTO ImageReferences (ImageReference)
   VALUES (imageReference)
   RETURNING ImageReferenceID INTO imageRefID;
   
   -- Insert the job request
   INSERT INTO JobRequests (JobRequestDescription, UserID, ImageReferenceID, JobTypeID, EstimatedCost)
   VALUES (jobRequestDescription, userID, imageRefID, jobTypeID, estimatedCost);
   
END;
$$;


-- Testing the procedure 
CALL spInsertJobRequest('something that i need done', 1, 'www.thisistheimagereference.png', 1, cast(450.00 as money));