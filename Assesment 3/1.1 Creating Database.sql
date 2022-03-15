--CREATING THE CUSTOMER DATABASE

CREATE TABLE Customer (
    cust_id int,
    cust_name varchar(100),
    cust_email varchar(100),
    cust_phn_no varchar(100),
   cust_add varchar(100)
);

--CREATING THE ORDER DATABASE

CREATE TABLE [Order] (
    ord_id int,
    cust_id int,
	ord_det varchar(500)
);