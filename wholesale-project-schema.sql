create table employee(
	employee_id varchar(30) primary  key,
	employee_name varchar(60) NOT NULL,
	employee_pass varchar(30),
	cnic char(13) not null,
	contact VARCHAR(13) NOT NULL,
	salary int,
	employee_address varchar(100),
	email varchar(50),
	designation VARCHAR(10) not null
);
create table companies(
	company_id varchar(40) primary key,
	supplier_name varchar(40),
	contact varchar(13) not null,
	email varchar(50)
);
create table product(
	product_ID varchar(20) primary key,
	product_name varchar(100) not null,
	price float not null,
	quantity int,
	company_id varchar(40) foreign key references companies(company_id)
);
INSERT INTO employee VALUES ('ehmad', 'Ehmad Saeed', '1234', '3630123456789', '03016672002', 50000, 'UET Lahore',
'justehmadsaeed@gmail.com','admin');
INSERT INTO companies VALUES('Giggly', 'Kashaan', '03014545455', 'info@giggly.com');
INSERT INTO product VALUES('pentene250ml', 'Pentene Shampoo 250ml', 300, 30, 'P&G' );
select * from employee
select * from companies
select * from product
