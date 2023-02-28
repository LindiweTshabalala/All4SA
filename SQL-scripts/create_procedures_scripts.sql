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



CREATE PROCEDURE add_donation_amount(increase_amount MONEY, jobrequestid_)
LANGUAGE plpgsql
AS $$
BEGIN
  UPDATE Donations SET Amount = Amount + increase_amount 
WHERE JobRequestID = jobrequestid_;
END;
$$;

CALL add_donation_amount(CAST(102.69 AS MONEY),1);