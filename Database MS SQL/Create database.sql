use master
go

create database InsulinDiary
go

use InsulinDiary
go

create table Notes
(
	ID int identity(1,1),
	DateOfMeasurement date,
	TimeOfMeasurement time,
	ReferenceValue decimal(3,1)
)
go

alter table Notes
add constraint PK_ID
primary key (ID)
go

insert into Notes(DateOfMeasurement, TimeOfMeasurement, ReferenceValue) values (N'2021-08-14', N'15:59', 5.9)
insert into Notes(DateOfMeasurement, TimeOfMeasurement, ReferenceValue) values (N'2021-08-15', N'10:02', 5.9)
insert into Notes(DateOfMeasurement, TimeOfMeasurement, ReferenceValue) values (N'2021-08-16', N'08:14', 5.9)
insert into Notes(DateOfMeasurement, TimeOfMeasurement, ReferenceValue) values (N'2021-08-17', N'19:08', 5.9)
insert into Notes(DateOfMeasurement, TimeOfMeasurement, ReferenceValue) values (N'2021-08-18', N'18:42', 5.9)
insert into Notes(DateOfMeasurement, TimeOfMeasurement, ReferenceValue) values (N'2021-08-19', N'16:37', 5.9)
insert into Notes(DateOfMeasurement, TimeOfMeasurement, ReferenceValue) values (N'2021-08-20', N'14:12', 5.9)

select * from Notes