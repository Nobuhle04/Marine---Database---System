/* Create our database here to store gym training programs and gym members */
CREATE DATABASE MarineDB;

/* Use our database so our sql knows where to work in */
USE MarineDB;

/* Create our tables here, to seperately hold the various fields of data */
CREATE TABLE Classes
(
	ClassID int,
	ClassName varchar (50),
	ClassDescription varchar (max),
	Instructor varchar (50),
	Schedule varchar (50),
	Capacity int,
	Duration varchar (50)
);

INSERT INTO Classes
VALUES
	(001, 'Yoga', 'Yoga is a practice that connects the body, breath, and mind through physical postures, breathing exercises, and meditation, aiming to improve overall health and well-being.', 'Rebecca Madisson', 'Twice a week', 25, '2 Hours'),
	(002, 'Pilates', 'Pilates is a type of mind-body exercise', 'Alex Russo', 'Twice a week', 30, 'Three Hours'),
	(003, 'Calisthenics', 'Calisthenics is a form of strength training that utilizes an individuals body weight as resistance to perform multi-joint, compound movements with little or no equipment.', 'Michael Ekhert', '5 Times a Week', 15, '3 Hours');

CREATE TABLE Members
(
	MemberID int,
	FirstName varchar (50),
	LastName varchar (50),
	DateOfBirth date,
	Gender varchar,
	PhoneNumber varchar (20),
	Location varchar (200),
	MemberShipStartDate date,
	MemberShipEndDate date
);

ALTER TABLE Members ALTER COLUMN Gender varchar (20);

INSERT INTO Members
VALUES
	(1, 'Nhlanhla', 'Sindane', '2000-01-01', 'Male', '0713572082', 'Grove Street', '2005-01-01', '2006-01-01'),
	(2, 'Nobuhle', 'Mosia', '2000-10-01', 'Female', '0814257897', 'Los Santos', '2005-01-01', '2006-01-01'),
	(3, 'Nomsa', 'Totwana', '2000-12-15', 'Female', '0201547896', 'San Andreas', '2005-01-01', '2006-01-01');
