CREATE VIEW [Customer And Their Oders] AS
SELECT ord_id,cust_name,cust_email,cust_add
FROM Customer  INNER JOIN [Order] 
ON Customer.cust_id = [Order].cust_id;

--SELECT * FROM [Customer And Their Oders];