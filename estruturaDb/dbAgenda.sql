CREATE DATABASE IF NOT EXISTS dbAgenda;

use dbAgenda;

CREATE TABLE IF NOT EXISTS tbUsuarios(
	nome VARCHAR(50) NOT NULL,
    usuario VARCHAR(30) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(20)
);
