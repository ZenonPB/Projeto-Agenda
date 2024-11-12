CREATE DATABASE IF NOT EXISTS dbAgenda;

use dbAgenda;

CREATE TABLE IF NOT EXISTS tbUsuarios(
	nome VARCHAR(50),
    usuario VARCHAR(30) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(20) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbCategorias(
	id INT PRIMARY KEY AUTO_INCREMENT,
    categoria VARCHAR(30) NOT NULL
);
INSERT INTO tbUsuarios (usuario, senha) VALUES ("admin", "admin123");