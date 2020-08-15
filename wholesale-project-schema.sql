create table product(
	product_ID varchar(20) primary key,
	product_name varchar(100) not null,
	price int not null,
	quantity int,
	company_id varchar(20)
);
create table employee(
	employee_id varchar(30) primary  key,
	employee_name varchar(60) NOT NULL,
	employee_pass varchar(30),
	cnic char(13) not null,
	contact VARCHAR(13) NOT NULL,
	salary int,
	employee_address varchar(100),
	email varchar(50),
	designation VARCHAR(20)
);
ALter table employee alter  column designation VARCHAR(20)  not null
INSERT INTO product(product_ID, product_name, price, quantity, company_id) VALUES('pentene250ml', 'Pentene Shampoo 250ml', 300, 30, 'P&G' );
select * from product
select * from employee
