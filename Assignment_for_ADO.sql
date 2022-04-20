Use Assignment_ADO
go

--Create table FootballLeague
Create table FootBall(
							MatchID  Int Primary key,
							TeamName1 nvarchar(30), 
							TeamName2 nvarchar(30), 	
							Status_ nvarchar(20),
							WinningTeam nvarchar(30),
							Points int
							);
--Insert into table FootBallLeague
INSERT INTO  FootBall 
VALUES
(1001,'Italy','France','Win','France',4),
(1002,'Brazil','Portugal','Draw',Null,2),
(1003,'England','Japan','Win','England',4),
(1004,'USA','Russia','Win','Russia',4),
(1005,'Portugal','Italy','Draw',Null,2),
(1006,'Brazil','France','Win','Brazil',4),
(1007,'England','Russia','Win','Russia',4),
(1008,'Japan','USA','Draw',Null,2);

--Selecting all elements from Football table
select * from FootBall;
--Create Stored Procedure
/*if not exists ( select * from sys.objects 
            where name='spFootballLeague' and objectproperty(object_id,'IsProcedure')=1 )*/
CREATE PROC spFootball
@MatchID int,
@TeamName1 varchar(30),
@TeamName2 varchar(30),
@Status_ varchar (10),
@WinningTeam varchar(30),
@Points varchar(10)
as
begin
	insert into FootBall values(@MatchID,@TeamName1,@TeamName2,@Status_,@WinningTeam,@Points);
end

--Executing Stored procedure spFootball
exec spFootball 1009,'Spain','Germany','Draw',null,'2';

--Retreiving data queries from the Football table
select WinningTeam from FootBall where Status_ ='win';
select *  from FootBall;

