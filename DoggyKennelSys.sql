-- DogKennelSys.sql
-- Joseph Diggins

-- Delete Data
DELETE FROM BookingServices;
DELETE FROM Bookings;
DELETE FROM Pets;
DELETE FROM Accounts;
DELETE FROM Services;
DELETE FROM Kennels;
DELETE FROM Sales;

-- Drop Tables
DROP TABLE BookingServices;
DROP TABLE Bookings;
DROP TABLE Pets;
DROP TABLE Accounts;
DROP TABLE Services;
DROP TABLE Kennels;
DROP TABLE Sales;

-- Create Tables & Add Data
CREATE TABLE Accounts (
  CustID numeric(4),
  FirstName varchar2(15),
  LastName varchar2(15),
  DOB date,
  Street varchar2(25),
  Town varchar2(15),
  County varchar2(9),
  Eircode char(7),
  Phone char(10) UNIQUE,
  Email varchar2(40) UNIQUE,
  CONSTRAINT pk_Accounts PRIMARY KEY (CustID));
  
INSERT INTO Accounts
VALUES(1, 'TOM', 'KENNEDY', TO_DATE('14/05/1990', 'DD/MM/YYYY'), 'ROCK STREET', 'TRALEE', 'KERRY', 'V92DW25', '0875557362', 'TOM@GMAIL.COM');
INSERT INTO Accounts
VALUES(2, 'ANNE', 'O''CONNOR', TO_DATE('19/10/1982', 'DD/MM/YYYY'), 'HIGH STREET', 'KILLARNEY', 'KERRY', 'V93FK49', '0871237776', 'ANNE_82@YAHOO.COM');
INSERT INTO Accounts
VALUES(3, 'MIKE', 'SMITH', TO_DATE('27/12/1999', 'DD/MM/YYYY'), 'MAIN STREET', 'KENMARE', 'KERRY', 'V93KDX0', '0871234567', 'MIKESMITH@GMAIL.COM');
INSERT INTO Accounts
VALUES(4, 'JOSEPH', 'DIGGINS', TO_DATE('01/02/1996', 'DD/MM/YYYY'), 'CAHERULLA', 'BALLYHEIGUE', 'KERRY', 'V92HD66', '0862156265', 'JOSEPHDIGGINS@GMAIL.COM');
INSERT INTO Accounts
VALUES(5, 'JASON', 'DIGGINS', TO_DATE('16/07/1997', 'DD/MM/YYYY'), 'THE VILLAGE', 'CAUSEWAY', 'KERRY', 'V92H9T0', '0876967398', 'JPD@GMAIL.COM');
INSERT INTO Accounts
VALUES(6, 'ROY', 'KEANE', TO_DATE('10/08/1971', 'DD/MM/YYYY'), 'BALLINDERRY PARK', 'MAYFIELD', 'CORK', 'T12DY8P', '0866260873', 'ROYKEANE@SKYSPORTS.COM');
INSERT INTO Accounts
VALUES(7, 'MICHAEL D.', 'HIGGINS', TO_DATE('18/04/1941', 'DD/MM/YYYY'), 'ARAS AN UACHTARAIN', 'PHOENIX PARK', 'DUBLIN', 'D08W4C6', '0834735263', 'MICHAELDHIGGINS@POI.COM');
INSERT INTO Accounts
VALUES(8, 'KATIE', 'TAYLOR', TO_DATE('02/07/1986', 'DD/MM/YYYY'), 'ST. KILLIANS', 'BRAY', 'WICKLOW', 'A98RH50', '0874324267', 'KTAYLOR86@GMAIL.COM');
INSERT INTO Accounts
VALUES(9, 'GRAHAM', 'NORTON', TO_DATE('04/04/1963', 'DD/MM/YYYY'), 'IRISHTOWN', 'BANDON', 'CORK', 'P72RP26', '0892227467', 'TGNS@BBC.COM');
INSERT INTO Accounts
VALUES(10, 'MICHAEL', 'FASSBENDER', TO_DATE('02/04/1977', 'DD/MM/YYYY'), 'FOSSA', 'KILLARNEY', 'KERRY', 'V93K409', '0861234561', 'FASSBENDER@HOTMAIL.COM');

CREATE TABLE Pets (
  PetID numeric(4),
  PetName varchar2(15),
  DOB date,
  Breed varchar2(20),
  PetSize char(1),
  Colour varchar2(20),
  Sex char(1),
  Neutered char(1),
  CustID numeric(4),
  CONSTRAINT pk_Pets PRIMARY KEY (PetID),
  CONSTRAINT fk_Pets_Accounts FOREIGN KEY (CustID) REFERENCES Accounts(CustID));
  
INSERT INTO Pets
VALUES (1, 'BUDDY', TO_DATE('16/09/2018', 'DD/MM/YYYY'), 'COLLIE', 'M', 'BLACK', 'M', 'Y', 1);
INSERT INTO Pets
VALUES (2, 'LEXI', TO_DATE('11/10/2015', 'DD/MM/YYYY'), 'DALMATIAN', 'M', 'BLACK/WHITE', 'F', 'Y', 2);
INSERT INTO Pets
VALUES (3, 'LADY', TO_DATE('25/05/2020', 'DD/MM/YYYY'), 'MALTESE', 'S', 'WHITE', 'F', 'N', 2);
INSERT INTO Pets
VALUES (4, 'TYSON', TO_DATE('03/03/2017', 'DD/MM/YYYY'), 'BOXER', 'L', 'BROWN', 'M', 'Y', 3);
INSERT INTO Pets
VALUES (5, 'LOTTIE', TO_DATE('01/01/2020', 'DD/MM/YYYY'), 'POMERANIAN', 'S', 'BROWN', 'F', 'Y', 4);
INSERT INTO Pets
VALUES (6, 'TUCKER', TO_DATE('01/04/2021', 'DD/MM/YYYY'), 'SHIBA INU', 'M', 'BROWN', 'M', 'N', 4);
INSERT INTO Pets
VALUES (7, 'BEARDY', TO_DATE('28/08/2010', 'DD/MM/YYYY'), 'SCOTTISH TERRIER', 'S', 'BLACK', 'M', 'N', 5);
INSERT INTO Pets
VALUES (8, 'JETT', TO_DATE('15/01/2016', 'DD/MM/YYYY'), 'GERMAN SHEPHERD', 'L', 'BLACK/BROWN', 'M', 'Y', 6);
INSERT INTO Pets
VALUES (9, 'UMA', TO_DATE('05/06/2019', 'DD/MM/YYYY'), 'LABRADOR', 'L', 'GOLDEN', 'F', 'Y', 6);
INSERT INTO Pets
VALUES (10, 'MISNEACH', TO_DATE('20/11/2020', 'DD/MM/YYYY'), 'BERNESE MOUNTAIN DOG', 'L', 'BLACK/BROWN/WHITE', 'M', 'N', 7);
INSERT INTO Pets
VALUES (11, 'BROD', TO_DATE('07/10/2014', 'DD/MM/YYYY'), 'BERNESE MOUNTAIN DOG', 'L', 'BLACK/BROWN/WHITE', 'M', 'Y', 7);
INSERT INTO Pets
VALUES (12, 'MARVIN', TO_DATE('04/04/2015', 'DD/MM/YYYY'), 'ITALIAN MASTIFF', 'M', 'GREY', 'M', 'Y', 8);
INSERT INTO Pets
VALUES (13, 'BELLE', TO_DATE('09/10/2020', 'DD/MM/YYYY'), 'POODLE', 'M', 'BLACK', 'F', 'Y', 9);
INSERT INTO Pets
VALUES (14, 'PADDY', TO_DATE('17/03/2017', 'DD/MM/YYYY'), 'PUG', 'S', 'CREAM', 'M', 'Y', 10);

CREATE TABLE Kennels (
  KennelNo numeric(3),
  KennelSize char(1),
  Cost decimal (4, 2),
  Status char(1),
  CONSTRAINT pk_Kennels PRIMARY KEY (KennelNo));
  
INSERT INTO Kennels
VALUES(1,'S',20,'A');

INSERT INTO Kennels
VALUES(2,'S',20,'A');

INSERT INTO Kennels
VALUES(3,'S',20,'A');

INSERT INTO Kennels
VALUES(4,'M',30,'A');

INSERT INTO Kennels
VALUES(5,'M',30,'A');

INSERT INTO Kennels
VALUES(6,'M',30,'A');

INSERT INTO Kennels
VALUES(7,'L',40,'A');

INSERT INTO Kennels
VALUES(8,'L',40,'A');

INSERT INTO Kennels
VALUES(9,'L',40,'A');

CREATE TABLE Services (
  Service_Code char(3),
  Description varchar(50),
  Rate decimal (4,2),
  Status char(1),
  CONSTRAINT pk_Services PRIMARY KEY (Service_Code));
  
INSERT INTO Services
VALUES('WSH','BRUSH, WARM BATH AND DRY. NO TRIMMING INCLUDED', 20, 'A');

INSERT INTO Services
VALUES('NLS','NAIL CLIPPING', 10, 'A');

INSERT INTO Services
VALUES('GRM', 'HEAD TO PAW GROOMING TAILORED TO YOUR DOG', 65, 'A');

INSERT INTO Services
VALUES('TRT','TREAT YOUR PET TO A SELECTION OF OUR DOGGY TREATS', 5, 'A');

INSERT INTO Services
VALUES('SLE', 'HALF PRICE GROOMING', 32.50, 'U');

INSERT INTO Services
VALUES('FST','FRONTLINE SPRAY TREATMENT AGAINST FLEAS AND TICKS', 7, 'A');

INSERT INTO Services
VALUES('CHK','EXAMINATION OF YOUR DOG FOR ANY IRREGULARITIES', 10, 'A');

INSERT INTO Services
VALUES('EAE','CLEANE EYS AND EARS REMOVING EXCESS WAX AND SLEEP', 15, 'A');

INSERT INTO Services
VALUES('CLG','SPRAY OF OUR LONG LASTING DOGGY COLOGNE', 5, 'A');

INSERT INTO Services
VALUES('MIN','MINI GROOM INCLUDES A TRIM AND A WARM BATH', 40, 'A');

CREATE TABLE Bookings (
  BookingID numeric(3),
  KennelNo numeric(3),
  Arrival_Date date,
  Dept_Date date,
  Cost decimal(5,2),
  PetID numeric(4),
  Status char(1),
  CONSTRAINT pk_Bookings PRIMARY KEY (BookingID),
  CONSTRAINT fk_Bookings_Kennels FOREIGN KEY (KennelNo) REFERENCES Kennels(KennelNo),
  CONSTRAINT fk_Bookings_Pets FOREIGN KEY (PetID) REFERENCES Pets(PetID));

-- JAN
INSERT INTO Bookings
VALUES(1, 7, TO_DATE('01/01/2022','DD/MM/YYYY'), TO_DATE('08/01/2022','DD/MM/YYYY'), 280, 9, 'O');

INSERT INTO Bookings
VALUES(2, 8, TO_DATE('01/01/2022','DD/MM/YYYY'), TO_DATE('08/01/2022','DD/MM/YYYY'), 280, 8, 'O');

INSERT INTO Bookings
VALUES(3, 4, TO_DATE('15/01/2022','DD/MM/YYYY'), TO_DATE('17/01/2022','DD/MM/YYYY'), 60, 12, 'O');

INSERT INTO Bookings
VALUES(4, 1, TO_DATE('11/01/2022','DD/MM/YYYY'), TO_DATE('15/01/2022','DD/MM/YYYY'), 80, 7, 'O');

INSERT INTO Bookings
VALUES(5, 5, TO_DATE('22/01/2022','DD/MM/YYYY'), TO_DATE('25/01/2022','DD/MM/YYYY'), 90, 6, 'O');

-- FEB
INSERT INTO Bookings
VALUES(6, 4, TO_DATE('01/02/2022','DD/MM/YYYY'), TO_DATE('05/02/2022','DD/MM/YYYY'), 120, 2, 'O');

INSERT INTO Bookings
VALUES(7, 1, TO_DATE('05/02/2022','DD/MM/YYYY'), TO_DATE('08/02/2022','DD/MM/YYYY'), 60, 3, 'O');

INSERT INTO Bookings
VALUES(8, 2, TO_DATE('15/02/2022','DD/MM/YYYY'), TO_DATE('17/02/2022','DD/MM/YYYY'), 40, 14, 'O');

INSERT INTO Bookings
VALUES(9, 6, TO_DATE('17/02/2022','DD/MM/YYYY'), TO_DATE('21/02/2022','DD/MM/YYYY'), 120, 13, 'O');

INSERT INTO Bookings
VALUES(10, 7, TO_DATE('25/02/2022','DD/MM/YYYY'), TO_DATE('28/02/2022','DD/MM/YYYY'), 120, 4, 'O');

-- MAR
INSERT INTO Bookings
VALUES(11, 4, TO_DATE('04/03/2022','DD/MM/YYYY'), TO_DATE('10/03/2022','DD/MM/YYYY'), 180, 1, 'O');

INSERT INTO Bookings
VALUES(12, 3, TO_DATE('02/03/2022','DD/MM/YYYY'), TO_DATE('09/03/2022','DD/MM/YYYY'), 140, 5, 'O');

INSERT INTO Bookings
VALUES(13, 7, TO_DATE('15/03/2022','DD/MM/YYYY'), TO_DATE('19/03/2022','DD/MM/YYYY'), 160, 10, 'O');

INSERT INTO Bookings
VALUES(14, 8, TO_DATE('15/03/2022','DD/MM/YYYY'), TO_DATE('19/03/2022','DD/MM/YYYY'), 160, 11, 'O');

INSERT INTO Bookings
VALUES(15, 5, TO_DATE('29/03/2022','DD/MM/YYYY'), TO_DATE('31/03/2022','DD/MM/YYYY'), 60, 9, 'O');

--APR
INSERT INTO Bookings
VALUES(16, 1, TO_DATE('03/04/2022','DD/MM/YYYY'), TO_DATE('08/04/2022','DD/MM/YYYY'), 100, 3, 'O');

INSERT INTO Bookings
VALUES(17, 7, TO_DATE('08/04/2022','DD/MM/YYYY'), TO_DATE('12/04/2022','DD/MM/YYYY'), 160, 4, 'O');

INSERT INTO Bookings
VALUES(18, 5, TO_DATE('12/04/2022','DD/MM/YYYY'), TO_DATE('19/04/2022','DD/MM/YYYY'), 210, 12, 'O');

INSERT INTO Bookings
VALUES(19, 8, TO_DATE('18/04/2022', 'DD/MM/YYYY'), TO_DATE('25/04/2022','DD/MM/YYYY'), 280, 8, 'I');

INSERT INTO Bookings
VALUES(20, 4, TO_DATE('19/04/2022','DD/MM/YYYY'), TO_DATE('26/04/2022','DD/MM/YYYY'), 210, 1, 'I');

INSERT INTO Bookings
VALUES(21, 2, TO_DATE('22/04/2022','DD/MM/YYYY'), TO_DATE('29/04/2022','DD/MM/YYYY'), 140, 14, 'I');

INSERT INTO Bookings
VALUES(22, 3, TO_DATE('25/04/2022','DD/MM/YYYY'), TO_DATE('30/04/2022','DD/MM/YYYY'), 40, 3, 'B');

INSERT INTO Bookings
VALUES(23, 1, TO_DATE('25/04/2022','DD/MM/YYYY'), TO_DATE('02/05/2022','DD/MM/YYYY'), 140, 5, 'I');

--MAY
INSERT INTO Bookings
VALUES(24, 6, TO_DATE('05/05/2022','DD/MM/YYYY'), TO_DATE('10/05/2022','DD/MM/YYYY'), 150, 6, 'B');

INSERT INTO Bookings
VALUES(25, 1, TO_DATE('13/05/2022','DD/MM/YYYY'), TO_DATE('16/05/2022','DD/MM/YYYY'), 60, 7, 'B');

INSERT INTO Bookings
VALUES(26, 7, TO_DATE('18/05/2022','DD/MM/YYYY'), TO_DATE('23/05/2022','DD/MM/YYYY'), 200, 4, 'B');

--JUN
INSERT INTO Bookings
VALUES(27, 4, TO_DATE('05/06/2022','DD/MM/YYYY'), TO_DATE('12/06/2022','DD/MM/YYYY'), 210, 1, 'B');

CREATE TABLE BookingServices (
  BookingID numeric (3),
  Service_Code char(3),
  Cost decimal(5,2),
  CONSTRAINT pk_BookingServices PRIMARY KEY(BookingID, Service_Code));
  
INSERT INTO BookingServices
VALUES(1, 'WSH', 20);

INSERT INTO BookingServices
VALUES(1, 'FST', 7);

INSERT INTO BookingServices
VALUES(3, 'GRM', 65);

INSERT INTO BookingServices
VALUES(4, 'EAE', 15);

INSERT INTO BookingServices
VALUES(6, 'NLS', 10);

INSERT INTO BookingServices
VALUES(6, 'CLG', 5);

INSERT INTO BookingServices
VALUES(8, 'MIN', 40);

INSERT INTO BookingServices
VALUES(10, 'CHK', 10);

INSERT INTO BookingServices
VALUES(11, 'WSH', 20);

INSERT INTO BookingServices
VALUES(11, 'CLG', 5);

INSERT INTO BookingServices
VALUES(15, 'GRM', 65);

INSERT INTO BookingServices
VALUES(16, 'TRT', 5);

INSERT INTO BookingServices
VALUES(16, 'CHK', 10);

INSERT INTO BookingServices
VALUES(16, 'EAE', 15);

INSERT INTO BookingServices
VALUES(18, 'GRM', 65);

INSERT INTO BookingServices
VALUES(18, 'NLS', 10);

INSERT INTO BookingServices
VALUES(18, 'TRT', 5);

INSERT INTO BookingServices
VALUES(20, 'GRM', 65);

INSERT INTO BookingServices
VALUES(20, 'FST', 7);

INSERT INTO BookingServices
VALUES(21, 'GRM', 65);

INSERT INTO BookingServices
VALUES(23, 'WSH', 20);

INSERT INTO BookingServices
VALUES(24, 'CHK', 10);

INSERT INTO BookingServices
VALUES(24, 'EAE', 15);

INSERT INTO BookingServices
VALUES(24, 'FST', 7);

INSERT INTO BookingServices
VALUES(26, 'MIN', 40);

INSERT INTO BookingServices
VALUES(27, 'WSH', 20);

INSERT INTO BookingServices
VALUES(27, 'NLS', 10);

INSERT INTO BookingServices
VALUES(27, 'CLG', 7);

CREATE TABLE Sales (
  SaleID numeric(3),
  SaleDate date,
  Total_Amount decimal (5, 2),
  Services_Amount decimal (5,2),
  CONSTRAINT pk_Sales PRIMARY KEY (SaleID));

INSERT INTO Sales
VALUES(1, TO_DATE('08/01/2022', 'DD/MM/YYYY'), 307, 27);

INSERT INTO Sales
VALUES(2, TO_DATE('08/01/2022', 'DD/MM/YYYY'), 280, 0);

INSERT INTO Sales
VALUES(3, TO_DATE('15/01/2022', 'DD/MM/YYYY'), 95, 15);

INSERT INTO Sales
VALUES(4, TO_DATE('17/01/2022', 'DD/MM/YYYY'), 125, 65);

INSERT INTO Sales
VALUES(5, TO_DATE('25/01/2022', 'DD/MM/YYYY'), 90, 0);

INSERT INTO Sales
VALUES(6, TO_DATE('05/02/2022', 'DD/MM/YYYY'), 135, 15);

INSERT INTO Sales
VALUES(7, TO_DATE('08/02/2022', 'DD/MM/YYYY'), 60, 0);

INSERT INTO Sales
VALUES(8, TO_DATE('17/02/2022', 'DD/MM/YYYY'), 80, 40);

INSERT INTO Sales
VALUES(9, TO_DATE('21/02/2022', 'DD/MM/YYYY'), 120, 0);

INSERT INTO Sales
VALUES(10, TO_DATE('28/02/2022', 'DD/MM/YYYY'), 130, 10);

INSERT INTO Sales
VALUES(11, TO_DATE('09/03/2022', 'DD/MM/YYYY'), 140, 0);

INSERT INTO Sales
VALUES(12, TO_DATE('10/03/2022', 'DD/MM/YYYY'), 205, 25);

INSERT INTO Sales
VALUES(13, TO_DATE('19/03/2022', 'DD/MM/YYYY'), 160, 0);

INSERT INTO Sales
VALUES(14, TO_DATE('19/03/2022', 'DD/MM/YYYY'), 160, 0);

INSERT INTO Sales
VALUES(15, TO_DATE('31/03/2022', 'DD/MM/YYYY'), 125, 65);

INSERT INTO Sales
VALUES(16, TO_DATE('08/04/2022', 'DD/MM/YYYY'), 130, 30);

INSERT INTO Sales
VALUES(17, TO_DATE('12/04/2022', 'DD/MM/YYYY'), 160, 0);

INSERT INTO Sales
VALUES(18, TO_DATE('19/04/2022', 'DD/MM/YYYY'), 290, 80);

COMMIT;