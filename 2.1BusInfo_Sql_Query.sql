Use Assignment_ADO
go

--Create Table BusInfo
CREATE TABLE BusInfo(
					BusID int primary key,
					BoardingPoint varchar(20) not null,
					TravelDate date not null,
					Amount decimal(10,2),
					Rating int not null
					);

--Insert into Table BusInfo
INSERT into BusInfo 
VALUES
(1,'BGL','06-18-2017',400.65,2),
(2,'HYD','10-05-2017',600.00,3),
(3,'CHN','07-25-2016',445.95,3),
(4,'PUN','12-10-2017',543.00,4),
(5,'MUM','01-28-2017',500.50,4),
(6,'PUN','03-27-2016',333.55,3),
(7,'MUM','11-06-2016',510.00,4);

select * from BusInfo;

--Create Stored procedure spBusInfo
CREATE PROCEDURE spBusInfo
@BusID int,
@BoardingPoint varchar(30),
@Traveldate date,
@Amount decimal(10,2),
@Rating int
as
begin
	insert into BusInfo values(@BusID,@BoardingPoint,@Traveldate,@Amount,@Rating);
end

--Retrieve all BoardingPoint and TravelDate for the amount which is greater than 450.
select BoardingPoint,TravelDate from BusInfo where Amount > 450.00;
--b.	Retrieve all the BusID, DroppingPoint for the bus travelled on 10-12-2017.
select BusId,BoardingPoint from BusInfo where TravelDate ='2017-12-10';