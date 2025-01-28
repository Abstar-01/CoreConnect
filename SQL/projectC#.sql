CREATE DATABASE db_HILCOE_STUDENT_SUPPORT

USE db_HILCOE_STUDENT_SUPPORT

CREATE TABLE Student (
		StudNum INT NOT NULL,
		SRC_StudID VARCHAR NOT NULL UNIQUE,
		First_Name VARCHAR(100) NOT NULL,
		Middle_Name VARCHAR(100) NOT NULL,
		Last_Name VARCHAR(100) NOT NULL,
		GENDER CHAR NOT NULL,
		BATCH VARCHAR(100) NOT NULL,
		Department VARCHAR(100)  NOT NULL,
		Degree VARCHAR(100) NOT NULL,
		PRIMARY KEY (StudNum)
)

CREATE TABLE Staff (
		StaffID INT NOT NULL,
		First_Name VARCHAR(100) NOT NULL,
		Middle_Name VARCHAR(100) NOT NULL,
		Last_Name VARCHAR(100) NOT NULL,
		GENDER CHAR NOT NULL,
		Department VARCHAR(100),
		Title VARCHAR(150),
		PRIMARY KEY (StaffID)
)

CREATE TABLE Contacts(
		StudID INT, 
		StaffID INT, 
		Phonenumber1 VARCHAR(50) UNIQUE NOT NULL,
		Phonenumber2 VARCHAR(50) UNIQUE,
		Email VARCHAR(150) UNIQUE, 
		Emergencycontact1 VARCHAR(50) NOT NULL,
		Emergencycontact2 VARCHAR(50) NOT NULL,
		FOREIGN KEY (StudID) REFERENCES Student(StudNum),
		FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
)

CREATE TABLE Course(
	CourseID INT NOT NULL,
	Course_Code VARCHAR(50) NOT NULL,
	Course_Name VARCHAR(150) NOT NULL, 
	StudID INT, 
	StaffID INT,
	PRIMARY KEY (CourseID),
	FOREIGN KEY (StudID) REFERENCES Student(StudNum),
	FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
)

CREATE TABLE Attendace(
		StudID INT, 
		StaffID INT, 
		Checkbox INT, 
		DAYDATE DATE,
		FOREIGN KEY (StudID) REFERENCES Student(StudNum),
		FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
)

CREATE TABLE Lecture_Mark_list(
		StudID INT, 
		StaffID INT,  
		Mid_Exam DECIMAL(18, 2),
		Final_Exam DECIMAL(18, 2),
		Cont_Assesment DECIMAL(18, 2),
		FOREIGN KEY (StudID) REFERENCES Student(StudNum),
		FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
)

CREATE TABLE Lab_Mark_list(
		StudID INT, 
		StaffID INT,  
		Lab_Assesment DECIMAL(18, 2),
		FOREIGN KEY (StudID) REFERENCES Student(StudNum),
		FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
)

CREATE TABLE Requests(
		StudID INT, 
		Request_Name VARCHAR(100),	
		Status_of_Request VARCHAR(50),
		FOREIGN KEY (StudID) REFERENCES Student(StudNum)
)

CREATE TABLE Road_map(
		StudID INT, 
		Course_title VARCHAR(150), 
		Course_status VARCHAR(100), 
		Department VARCHAR(100), 
		Course_grade VARCHAR(5),
		FOREIGN KEY (StudID) REFERENCES Student(StudNum)

)