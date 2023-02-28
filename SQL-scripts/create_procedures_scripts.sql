CREATE PROCEDURE add_downvote(IN publicvoteid_ INT)
LANGUAGE SQL
AS $$
UPDATE publicvotes
SET downvotes = downvotes + 1
WHERE publicvoteid = publicvoteid_;
$$;


CREATE PROCEDURE add_upvote(IN publicvoteid_ INT)
LANGUAGE SQL
AS $$
UPDATE publicvotes
SET upvotes = upvotes + 1
WHERE publicvoteid = publicvoteid_;
$$;



CREATE PROCEDURE add_donation_amount(increase_amount MONEY, jobrequestid_ INT)
LANGUAGE plpgsql
AS $$
BEGIN
  UPDATE Donations SET Amount = Amount + increase_amount 
WHERE JobRequestID = jobrequestid_;
END;
$$;

CALL add_donation_amount(CAST(102.69 AS MONEY),1);



CREATE OR REPLACE PROCEDURE sp_add_user(
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
   
    BEGIN
      
        INSERT INTO Users (FirstName, Surname, IdNumber, token) 
			   VALUES (first_name, surname, id_number, token_) RETURNING UserID INTO user_id;

        INSERT INTO Contacts (Email, CellPhone, UserID) 
			   VALUES (email, cell_phone, user_id);

        INSERT INTO Addresses (Province, City, StreetName, PostalCode, UserID)
			  VALUES (province, city, street_name, postal_code, user_id);

    EXCEPTION WHEN OTHERS THEN
        RAISE NOTICE 'Error adding user with contact and address: %', SQLERRM;
        ROLLBACK;
        RETURN;
    END;
    COMMIT;
END;
$$;

call sp_add_user('Done', 'Mashaba', '3505230824520','gldfjdfhdsgfjhdgshfdsagldsf','done@yahoo.com',
				 '0736256300','North West', 'Porch','Near Me', 1912 );