ALTER TABLE [Order]
ADD FOREIGN KEY (cust_id) REFERENCES Customer(cust_id);