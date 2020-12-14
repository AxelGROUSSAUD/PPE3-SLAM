drop database if exists LSRGames ;
create database LSRGames;
use LSRGames;

create table Utilisateur(
id int,
Login varchar(75) unique,
MotDePasse varchar(30),
primary key(id)
) engine InnoDB;

create table Client(
id int,
nom varchar(30),
prenom varchar(30),
photo varchar(200),
adresse varchar(150),
DateNaissance date,
Email varchar(150),
TelephonePortable char(10),
Credit double,
primary key(id)
) engine InnoDB;

create table Obstacle(
nom varchar(100),
UneDefinition varchar(255),
Photo varchar(255),
typeObstacle varchar(75),
primary key(nom)
)engine InnoDB;

create table Themes(
id int,
theme varchar(50),
primary key(id)
)engine InnoDB;

create table Salle(
id int,
ville varchar(45),
idTheme int,
primary key(id),
foreign key (idTheme) references Themes(id) on update cascade on delete cascade
)engine InnoDB;

create table Transactions(
id int,
idClient int,
MontantTransaction double,
primary key(id),
foreign key(idClient) references Client(id) on update cascade on delete cascade
) engine InnoDB;

create table Reservation(
id int,
idClient int,
DateReservation DateTime,
nbJoueurs int check(nbJoueurs <=7),
nbObstacle int check(nbObstacle <=12),
idSalle int,
idTransaction int,
primary key(id),
foreign key(idClient) references Client(id) on update cascade on delete cascade,
foreign key(idSalle) references Salle(id) on update cascade on delete cascade,
foreign key(idTransaction) references Transactions(id) on update cascade on delete cascade
) engine InnoDB;

create table Avis(
id int auto_increment,
idClient int,
idSalle int,
avis varchar(255),
primary key(id),
foreign key(idClient) references Client(id) on update cascade on delete cascade,
foreign key(idSalle) references Salle(id) on update cascade on delete cascade
)engine InnoDB;

create table PositionObstacle(
id int auto_increment,
nomObstacle varchar(100),
idReservation int,
PositionObstacle int check(PositionObstacle <=12),
primary key(id),
foreign key(nomObstacle) references Obstacle(nom) on update cascade on delete cascade,
foreign key(idReservation) references Reservation(id) on update cascade on delete cascade
)engine InnoDB;


insert into Themes values(1,"basique");

 

insert into Salle values(1,"Annecy",1);
insert into Salle values(2,"Annecy",1);
insert into Salle values(3,"Annecy",1);
insert into Salle values(4,"Annecy",1);

insert Obstacle values ('Piano','une définition du piano','une photo','Instrument');
 insert Obstacle values ('Barrière de Force','une définition de la barrière de force','une photo','Barrière');
insert Obstacle values ('Tapis de danse','une définition du tapis de danse','une photo','Tapis');


insert into Client values (1,"GROUSSAUD","Axel","dhfgvhf","14 rue de la paix","1999-10-27","axel.groussaud@saintmichelannecy.fr","0125489446",12);

 

insert into Transactions values (1,1,25.50);
 
 insert into Reservation values(4,1,"2020-12-03 10:00:00",5,5,1,null);
  insert into Reservation values(2,1,"2021-1-03 10:00:00",5,12,1,1);
 insert into Reservation values(3,1,"2020-12-25 10:00:00",7,5,1,1);

insert into PositionObstacle values (2,"Piano",4,5);
insert into PositionObstacle values (3,"Barrière de Force",4,3);
insert into PositionObstacle values (4,"Tapis de danse",4,7);


 select count(id) from Reservation where dayofweek(DateReservation) = 5 and hour(DateReservation) = '10 % ';
 select count(id) as NbSalles from Salle where id not in (select count(id) from Reservation where dayofmonth(DateReservation)= 3 and month(DateReservation) = 1 and year(DateReservation) = 2021 and hour(DateReservation) = '10 % ');
select * from Reservation;