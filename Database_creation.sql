use BDB56TP25

drop table Depenses
drop table Services
drop table Employes
drop table Dependants
drop table PartiesJouees
drop table Terrains
drop table Reabonnements
drop table Abonnements
drop table PrixDepensesAbonnements
drop table TypesAbonnement
drop table Provinces
drop table TypesEmploye



create table TypesEmploye (
	No int not null primary key,
	Description varchar(50) not null,
	Remarque varchar(50)
)
create table Provinces(
	Id varchar(2) not null primary key,
	Nom varchar(50) not null,
	Remarque varchar(50)
)

create table Employes(
	No int not null primary key,
	MotDePasse varchar(50) not null,
	Nom varchar(50) not null,
	Prenom varchar(50) not null,
	Sexe nchar not null,
	Age int not null,
	NoCivique int not null,
	Rue varchar(50) not null,
	Ville varchar(50) not null,
	IdProvince varchar(2) not null,
	CodePostal varchar(6) not null,
	Telephone varchar(10) not null,
	Cellulaire varchar(10),
	Courriel varchar(50) not null,
	SalaireHoraire money not null,
	NoTypeEmploye int not null,
	Remarque varchar(50),
	foreign key (NoTypeEmploye) references TypesEmploye(No),
	foreign key (IdProvince) references Provinces(Id)
)

create table TypesAbonnement(
	No int not null primary key,
	Description varchar(50) not null,
	Remarque varchar(50)
)

create table Abonnements(
	Id varchar(50) not null primary key,
	DataAbonnement date not null,
	Nom varchar(50) not null,
	Prenom varchar(50) not null,
	Sexe nchar not null,
	DateNaissance date not null,
	NoCivique int not null,
	Rue varchar(50) not null,
	Ville varchar(50) not null,
	IdProvince varchar(2) not null,
	CodePostal varchar(6) not null,
	Telephone varchar(10) not null,
	Cellulaire varchar(10),
	Courriel varchar(50) not null,
	NoTypeAbonnement int not null,
	Remarque varchar(50),
	foreign key (IdProvince) references Provinces(Id),
	foreign key (NoTypeAbonnement) references TypesAbonnement(No)
)

create table Reabonnements(
	IdAbonnement varchar(50) not null,
	DateRenouvellement date not null,
	Remarque varchar(50),
	foreign key (IdAbonnement) references Abonnements(Id),
	primary key(IdAbonnement, DateRenouvellement)
)

create table Terrains(
	No int not null primary key,
	Nom varchar(50) not null,
	NombreTrous int not null,
	Description varchar(50) not null,
	Remarque varchar(50)
)

create table PartiesJouees(
	IdAbonnement varchar(50) not null,
	NoTerrain int not null,
	DatePartie date not null,
	Pointage varchar(50) not null,
	Remarque varchar(50),
	foreign key (IdAbonnement) references Abonnements(Id),
	foreign key (NoTerrain) references Terrains(No),
	primary key (IdAbonnement,NoTerrain,DatePartie)
)

create table Dependants(
	Id varchar(50) not null primary key,
	Nom varchar(50) not null,
	Prenom varchar(50) not null,
	Sexe nchar not null,
	DateNaissance date not null,
	IdAbonnement varchar(50) not null,
	Remarque varchar(50),
	foreign key (IdAbonnement) references Abonnements(Id)
)

create table Services(
	No int not null primary key,
	TypeService varchar(50) not null,
	NoEmploye int not null,
	Remarque varchar(50),
	foreign key (NoEmploye) references Employes(No)
)

create table Depenses(
	No int not null primary key,
	IdAbonnement varchar(50) not null,
	DateDepense date not null,
	Montant money not null,
	NoService int not null,
	Remarque varchar(50),
	foreign key (IdAbonnement) references Abonnements(Id),
	foreign key (NoService) references Services(No)
)

create table PrixDepensesAbonnements(
	NoTypeAbonnement int not null,
	Annee date not null,
	Prix money not null,
	DepensesObligatoires money not null,
	Remarques varchar(50),
	primary key(NoTypeAbonnement, Annee),
	foreign key (NoTypeAbonnement) references TypesAbonnement(No)
)

insert into Provinces values ('AB','Alberta','')
insert into Provinces values ('BC','Colombie-Britannique','')
insert into Provinces values ('MB','Manitoba','')
insert into Provinces values ('NB','Nouveau-Brunswick','')
insert into Provinces values ('NL','Terre-Neuve et Labrador','')
insert into Provinces values ('NT','Territoires du Nord-Ouest','')
insert into Provinces values ('NS','Nouvelle-Écosse','')
insert into Provinces values ('NU','Nunavut','')
insert into Provinces values ('ON','Ontario','')
insert into Provinces values ('PE','Île-du-Prince-Édouard','')
insert into Provinces values ('QC','Québec','')
insert into Provinces values ('SK','Saskatchewan','')
insert into Provinces values ('YT','Territoire du Yukon','')


insert into TypesEmploye values (1,'Administrateur','Il n''y en a qu''un et son numéro est 1')
insert into TypesEmploye values (2,'Direction','')
insert into TypesEmploye values (3,'Propriétaire d''un club','')
insert into TypesEmploye values (4,'Employé d''un club','')
insert into TypesEmploye values (5,'Employé Pro-Shop','')
insert into TypesEmploye values (6,'Employé d''un restaurant','')
insert into TypesEmploye values (7,'Professeur de golf','')

insert into TypesAbonnement values (1,'Personne seule','')
insert into PrixDepensesAbonnements values (1,'01-01-2020',850,400,'')
insert into TypesAbonnement values (2,'Âge d''or','')
insert into PrixDepensesAbonnements values (2,'01-01-2020',500,400,'')
insert into TypesAbonnement values (3,'Couple','')
insert into PrixDepensesAbonnements values (3,'01-01-2020',1200,700,'')
insert into TypesAbonnement values (4,'Famille (couple + 1 enfant)','')
insert into PrixDepensesAbonnements values (4,'01-01-2020',1700,700,'')
insert into TypesAbonnement values (5,'Famille (couple + 2 enfants)','')
insert into PrixDepensesAbonnements values (5,'01-01-2020',1900,700,'')
insert into TypesAbonnement values (6,'Famille (couple + 3 enfants)','')
insert into PrixDepensesAbonnements values (6,'01-01-2020',2100,700,'')

insert into Employes values (1, 'Password1$','Santerre','Félix-André','H',19,126,'Jacques-Plantes','Vaudreuil','QC','J7V0R7','4504246320','5149236320','fasanterre@hotmail.com',14,1,'')

insert into Terrains values (1,'Cypress Point',18,'Superbe terrain de 18 trous','')
insert into Terrains values (2,'Whistling Straits',18,'Superbe terrain de 18 trous','')
insert into Terrains values (3,'Pebble Beach',18,'Superbe terrain de 18 trous','')
insert into Terrains values (4,'Augusta National',9,'Superbe terrain de 9 trous','')
insert into Terrains values (5,'Spyglass Hill',9,'Superbe terrain de 9 trous','')
insert into Terrains values (6,'Royal Portrush',9,'Superbe terrain de 9 trous','')