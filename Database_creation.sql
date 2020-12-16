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
	DepensesObligatoires varchar(50) not null,
	Remarques varchar(50),
	primary key(NoTypeAbonnement, Annee),
	foreign key (NoTypeAbonnement) references TypesAbonnement(No)
)