SELECT  ord_id,cust_name,cust_email,cust_add
FROM [Order] 
FULL OUTER JOIN [Customer]
ON Customer.cust_id = [Order].cust_id;