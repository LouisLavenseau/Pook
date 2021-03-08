
drop table if exists utilisateur;
drop table if exists album;
drop table if exists utilisateur_album;
drop table if exists administrateur;
drop table if exists messouhaits;


create table utilisateur (
    utilisateur_id integer not null primary key auto_increment,
    utilisateur_login varchar(100) not null,
	utilisateur_mdp varchar(100) not null,
	utilisateur_nomImagePdp varchar(100) not null
);

create table album (
    album_id integer not null primary key auto_increment,
	album_nom varchar(100) not null,
    album_imagecouverture varchar(100) not null,
	album_serie varchar(20) not null,
	album_auteurs varchar(100) not null,
	album_categorie varchar(100) not null,
	album_genre varchar(100) not null,
	album_editeur varchar(100) not null,
	album_correspondALaRecherche boolean not null

);

create table administrateur (
	administrateur_id integer not null primary key auto_increment,
	administrateur_login varchar(100) not null,
	administrateur_mdp varchar(100) not null
);

create table mesAlbums (
	utilisateur_id integer not null,
	album_id integer not null,
	constraint fk_utilisateur_album foreign key(utilisateur_id) references utilisateur(utilisateur_id),
	constraint fk_album_utilisateur foreign key(album_id) references album(album_id)
	);
	
	create table mesSouhaits (
	utilisateur_id integer not null,
	album_id integer not null,
	constraint fk_utilisateur_souhait foreign key(utilisateur_id) references utilisateur(utilisateur_id),
	constraint fk_souhait_utilisateur foreign key(album_id) references album(album_id)
	);
	





