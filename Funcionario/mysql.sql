/*Create database cria um bacno de dados*/

create database dbFuncionarios
default character set utf8mb4
default collate utf8mb4_general_ci;

/*
	Parte inicial configura o mysql a identificar os caracteres da nossa linguagem
*/

use dbFuncionarios;

create table if not exists funcionarios (
	id int not null auto_increment primary key,
    nome varchar (100) not null,
    email varchar (100) not null,
    cpf varchar (14) not null,
    endereco varchar (200) not null
)default char set utf8mb4;
