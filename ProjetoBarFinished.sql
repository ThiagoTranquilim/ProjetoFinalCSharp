-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.24-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para projeto_bar
DROP DATABASE IF EXISTS `projeto_bar`;
CREATE DATABASE IF NOT EXISTS `projeto_bar` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `projeto_bar`;

-- Copiando estrutura para tabela projeto_bar.categoria
DROP TABLE IF EXISTS `categoria`;
CREATE TABLE IF NOT EXISTS `categoria` (
  `codCategoria` int(11) NOT NULL AUTO_INCREMENT,
  `nomeCategoria` varchar(100) NOT NULL,
  PRIMARY KEY (`codCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela projeto_bar.categoria: ~3 rows (aproximadamente)
INSERT INTO `categoria` (`codCategoria`, `nomeCategoria`) VALUES
	(1, 'Bebidas Alcoolicas'),
	(2, 'Salgados'),
	(3, 'Sucos Naturais'),
	(4, 'Prato Feito'),
	(5, ''),
	(6, 'Salgados Fritos');

-- Copiando estrutura para tabela projeto_bar.cliente
DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `codCliente` int(11) NOT NULL AUTO_INCREMENT,
  `nomeCliente` varchar(200) NOT NULL,
  `enderecoCliente` varchar(200) NOT NULL,
  `telefoneCliente` varchar(45) NOT NULL,
  `cpfCliente` varchar(45) NOT NULL,
  PRIMARY KEY (`codCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela projeto_bar.cliente: ~5 rows (aproximadamente)
INSERT INTO `cliente` (`codCliente`, `nomeCliente`, `enderecoCliente`, `telefoneCliente`, `cpfCliente`) VALUES
	(2, 'Thiago', 'Rua Douglas', '1987453452', '098345345065'),
	(3, 'Joao Cardoso', 'Rua Douglas', '4309854832', '12356345698'),
	(4, 'Gustavo', 'Rua Douglas Goncalves', '1974854345', '04532497658'),
	(8, 'Leonardo', 'Rua Douglas', '3509384957', '483950489608'),
	(9, 'Samuel', 'Av Padre Peixoto', '3586975069', '0796897690708');

-- Copiando estrutura para procedure projeto_bar.consultaLogin
DROP PROCEDURE IF EXISTS `consultaLogin`;
DELIMITER //
CREATE PROCEDURE `consultaLogin`(usuario varchar(100), senha varchar(100))
BEGIN
Select * from usuarios where usuarios.nome = usuario and usuarios.senha = senha;
END//
DELIMITER ;

-- Copiando estrutura para tabela projeto_bar.marca
DROP TABLE IF EXISTS `marca`;
CREATE TABLE IF NOT EXISTS `marca` (
  `codMarca` int(11) NOT NULL AUTO_INCREMENT,
  `nomeMarca` varchar(45) NOT NULL,
  PRIMARY KEY (`codMarca`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela projeto_bar.marca: ~12 rows (aproximadamente)
INSERT INTO `marca` (`codMarca`, `nomeMarca`) VALUES
	(1, 'Heineken'),
	(2, 'Budweiser'),
	(3, 'Brahma'),
	(4, 'Kaiser'),
	(5, 'Del valle'),
	(6, 'Vodka'),
	(7, 'Whisky'),
	(8, 'Rum'),
	(9, 'Uísque'),
	(10, 'Licor de Pessego'),
	(11, 'Gin'),
	(12, 'Bourbon'),
	(13, 'Tequila'),
	(14, 'Espumante'),
	(15, 'Corona');

-- Copiando estrutura para procedure projeto_bar.proc_alteraCategoria
DROP PROCEDURE IF EXISTS `proc_alteraCategoria`;
DELIMITER //
CREATE PROCEDURE `proc_alteraCategoria`(IN nomeAlterado varchar(200), IN codigo int)
BEGIN
	update categoria set nomeCategoria = nomeAlterado where codCategoria = codigo;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_alteraCliente
DROP PROCEDURE IF EXISTS `proc_alteraCliente`;
DELIMITER //
CREATE PROCEDURE `proc_alteraCliente`(IN nomeNovoCliente varchar(200), in enderecoNovoCliente varchar(200), in telefoneNovoCliente varchar(45), cpfNovoCliente varchar(45), in codigo int)
BEGIN
	update cliente set nomeCliente = nomeNovoCliente, enderecoCliente = enderecoNovoCliente, telefoneCliente = telefoneNovoCliente, cpfCliente = cpfNovoCliente where codCliente = codigo;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_alteraMarca
DROP PROCEDURE IF EXISTS `proc_alteraMarca`;
DELIMITER //
CREATE PROCEDURE `proc_alteraMarca`(IN nomeAlterado varchar(100), IN codigo int)
BEGIN
	update marca set nomeMarca = nomeAlterado where codMarca = codigo;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_alteraProduto
DROP PROCEDURE IF EXISTS `proc_alteraProduto`;
DELIMITER //
CREATE PROCEDURE `proc_alteraProduto`(IN nomeNovoProduto varchar(200), in precoNovoCusto decimal, in precoNovoVenda decimal, in fkcodMarca int, in fkcodCategoria int, codigo int)
BEGIN
	update produto set nomeProduto = nomeNovoProduto, precoCusto = precoNovoCusto, precoVenda = precoNovoVenda, MARCA_codMarca = fkcodMarca, CATEGORIA_codCategoria = fkcodCategoria where codProduto = codigo;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_alteraVenda
DROP PROCEDURE IF EXISTS `proc_alteraVenda`;
DELIMITER //
CREATE PROCEDURE `proc_alteraVenda`(in mesaNovoVenda int, in dataNovoHoraVenda datetime, in fkcodNovoCliente int, in codigo int)
BEGIN
	update venda set mesaVenda = mesaNovoVenda, dataHoraVenda = dataNovoHoraVenda, CLIENTE_codCliente = fkcodNovoCliente where codVenda = codigo;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_deleteCategoria
DROP PROCEDURE IF EXISTS `proc_deleteCategoria`;
DELIMITER //
CREATE PROCEDURE `proc_deleteCategoria`(IN codigoApaga int)
BEGIN
	delete from categoria where codCategoria = codigoApaga;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_deleteCliente
DROP PROCEDURE IF EXISTS `proc_deleteCliente`;
DELIMITER //
CREATE PROCEDURE `proc_deleteCliente`(in codigo int)
BEGIN
	delete from cliente where codCliente = codigo;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_deleteMarca
DROP PROCEDURE IF EXISTS `proc_deleteMarca`;
DELIMITER //
CREATE PROCEDURE `proc_deleteMarca`(IN codigoApaga int)
BEGIN
	delete from marca where codMarca = codigoApaga;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_deleteProduto
DROP PROCEDURE IF EXISTS `proc_deleteProduto`;
DELIMITER //
CREATE PROCEDURE `proc_deleteProduto`(in codigo int)
BEGIN
	delete from produto where codProduto = codigo;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_deleteVenda
DROP PROCEDURE IF EXISTS `proc_deleteVenda`;
DELIMITER //
CREATE PROCEDURE `proc_deleteVenda`(in codigo int)
BEGIN
	delete from venda where codVenda = codigo;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_insereCategoria
DROP PROCEDURE IF EXISTS `proc_insereCategoria`;
DELIMITER //
CREATE PROCEDURE `proc_insereCategoria`(IN nomeNovo varchar(200))
BEGIN
	insert into `projeto_bar`.`categoria`
    (`nomeCategoria`)
    values
    (`nomeNovo`);
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_insereCliente
DROP PROCEDURE IF EXISTS `proc_insereCliente`;
DELIMITER //
CREATE PROCEDURE `proc_insereCliente`(IN nomeCliente varchar(200), in enderecoCliente varchar(200), in telefoneCliente varchar(45), cpfCliente varchar(45))
BEGIN
	insert into cliente values(null, nomeCliente, enderecoCliente, telefoneCliente, cpfCliente);
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_insereMarca
DROP PROCEDURE IF EXISTS `proc_insereMarca`;
DELIMITER //
CREATE PROCEDURE `proc_insereMarca`(IN nomeNovo varchar(200))
BEGIN
	insert into `projeto_bar`.`marca`
    (`nomeMarca`)
    values
    (`nomeNovo`);
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_insereProduto
DROP PROCEDURE IF EXISTS `proc_insereProduto`;
DELIMITER //
CREATE PROCEDURE `proc_insereProduto`(IN nomeProduto varchar(200), in precoCusto decimal, in precoVenda decimal, in MARCA_codMarca int, in CATEGORIA_codCategoria int)
BEGIN
	insert into produto values(null, nomeProduto, precoCusto, precoVenda, MARCA_codMarca, CATEGORIA_codCategoria);
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_insereVenda
DROP PROCEDURE IF EXISTS `proc_insereVenda`;
DELIMITER //
CREATE PROCEDURE `proc_insereVenda`(in mesaCliente int, in dataHoraVenda datetime, in fkcodCliente int)
BEGIN
	insert into venda values(null, mesaCliente, dataHoraVenda, fkcodCliente);
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_listaCategoria
DROP PROCEDURE IF EXISTS `proc_listaCategoria`;
DELIMITER //
CREATE PROCEDURE `proc_listaCategoria`()
BEGIN
	select * from categoria;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_listaCliente
DROP PROCEDURE IF EXISTS `proc_listaCliente`;
DELIMITER //
CREATE PROCEDURE `proc_listaCliente`()
BEGIN
	SELECT codCliente,
    nomeCliente as "Nome",
    enderecoCliente as "Endereco",
    telefoneCliente as "Telefone",
    cpfCliente as "CPF"
    FROM cliente;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_listaClienteCodAndNome
DROP PROCEDURE IF EXISTS `proc_listaClienteCodAndNome`;
DELIMITER //
CREATE PROCEDURE `proc_listaClienteCodAndNome`()
BEGIN
	SELECT codCliente,
    nomeCliente as "Nome"
    FROM cliente;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_listaMarca
DROP PROCEDURE IF EXISTS `proc_listaMarca`;
DELIMITER //
CREATE PROCEDURE `proc_listaMarca`()
BEGIN
	select * from marca;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_listaProduto
DROP PROCEDURE IF EXISTS `proc_listaProduto`;
DELIMITER //
CREATE PROCEDURE `proc_listaProduto`()
BEGIN
	SELECT codProduto,
		marca.nomeMarca as "Marca",
		nomeProduto as "Nome",
		PrecoVenda as "Preco",
		categoria.nomeCategoria as "Categoria"
	FROM produto
	INNER JOIN marca on
	    produto.MARCA_codMarca = marca.codMarca
	INNER JOIN categoria on
		produto.CATEGORIA_codCategoria = categoria.codCategoria;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_listaProdutoCodAndNome
DROP PROCEDURE IF EXISTS `proc_listaProdutoCodAndNome`;
DELIMITER //
CREATE PROCEDURE `proc_listaProdutoCodAndNome`()
BEGIN
	SELECT codProduto,
		nomeProduto as "Nome"
	FROM produto;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_listaVenda
DROP PROCEDURE IF EXISTS `proc_listaVenda`;
DELIMITER //
CREATE PROCEDURE `proc_listaVenda`()
BEGIN
	SELECT codVenda,
    mesaVenda as "Mesa",
    dataHoraVenda as "Data e Hora",
    cliente.nomeCliente as "Cliente"
    FROM venda
    INNER JOIN cliente on
		venda.CLIENTE_codCliente = cliente.codCliente;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_listaVendaCodandNome
DROP PROCEDURE IF EXISTS `proc_listaVendaCodandNome`;
DELIMITER //
CREATE PROCEDURE `proc_listaVendaCodandNome`()
BEGIN
	SELECT codVenda,
    mesaVenda as "Mesa"
    FROM venda;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_UpdateCliente
DROP PROCEDURE IF EXISTS `proc_UpdateCliente`;
DELIMITER //
CREATE PROCEDURE `proc_UpdateCliente`(nomeAlterado varchar(200), in enderecoAlterado varchar(200), in telefoneAlterado varchar(45), cpfAlterado varchar(45), codigo int)
BEGIN
	UPDATE cliente
	SET
	`nomeCliente` = nomeAlterado,
	`enderecoCliente` = enderecoAlterado,
	`telefoneCliente` = telefoneAlterado,
	`cpfCliente` = cpfAlterado
	WHERE `codCliente` = codigo;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_UpdateProduto
DROP PROCEDURE IF EXISTS `proc_UpdateProduto`;
DELIMITER //
CREATE PROCEDURE `proc_UpdateProduto`(nomeAlterado varchar(200), custoAlterado decimal, vendaAlterado decimal, marcaAlterado int, categoriaAlterado int, codigo int)
BEGIN
	UPDATE produto
	SET
	`nomeProduto` = nomeAlterado,
	`precoCusto` = custoAlterado,
	`precoVenda` = vendaAlterado,
	`MARCA_codMarca` = marcaAlterado,
	`CATEGORIA_codCategoria` = categoriaAlterado
	WHERE `codProduto` = codigo;
END//
DELIMITER ;

-- Copiando estrutura para procedure projeto_bar.proc_UpdateVenda
DROP PROCEDURE IF EXISTS `proc_UpdateVenda`;
DELIMITER //
CREATE PROCEDURE `proc_UpdateVenda`(in mesaAlterado int, in dataAlterado datetime, in fkcodClienteAlterado int, codigo int)
BEGIN
	UPDATE venda
	SET
	`mesaVenda` = mesaAlterado,
	`dataHoraVenda` = dataAlterado,
	`CLIENTE_codCliente` = fkcodClienteAlterado
	WHERE `codVenda` = codigo;
END//
DELIMITER ;

-- Copiando estrutura para tabela projeto_bar.produto
DROP TABLE IF EXISTS `produto`;
CREATE TABLE IF NOT EXISTS `produto` (
  `codProduto` int(11) NOT NULL AUTO_INCREMENT,
  `nomeProduto` varchar(200) NOT NULL,
  `precoCusto` decimal(10,2) unsigned NOT NULL,
  `precoVenda` decimal(10,2) NOT NULL,
  `MARCA_codMarca` int(11) NOT NULL,
  `CATEGORIA_codCategoria` int(11) NOT NULL,
  PRIMARY KEY (`codProduto`,`MARCA_codMarca`,`CATEGORIA_codCategoria`),
  KEY `fk_PRODUTO_MARCA1_idx` (`MARCA_codMarca`),
  KEY `fk_PRODUTO_CATEGORIA1_idx` (`CATEGORIA_codCategoria`),
  CONSTRAINT `fk_PRODUTO_CATEGORIA1` FOREIGN KEY (`CATEGORIA_codCategoria`) REFERENCES `categoria` (`codCategoria`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PRODUTO_MARCA1` FOREIGN KEY (`MARCA_codMarca`) REFERENCES `marca` (`codMarca`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela projeto_bar.produto: ~19 rows (aproximadamente)
INSERT INTO `produto` (`codProduto`, `nomeProduto`, `precoCusto`, `precoVenda`, `MARCA_codMarca`, `CATEGORIA_codCategoria`) VALUES
	(38, 'Teste10', 1.00, 2.00, 2, 3),
	(40, 'Bloody Mary', 10.00, 32.00, 6, 1),
	(41, 'Manhattan', 10.00, 40.00, 11, 1),
	(42, 'Sex on the Beach', 10.00, 30.00, 10, 1),
	(43, 'Dry Martini', 20.00, 55.00, 11, 1),
	(44, 'Fresh Mojito', 10.00, 19.00, 6, 1),
	(45, 'Moscow Mulle', 10.00, 40.00, 6, 1),
	(46, 'Negroni', 50.00, 140.00, 12, 1),
	(47, 'Basel Smash', 10.00, 17.00, 9, 1),
	(48, 'Pina Colada', 5.00, 10.00, 6, 1),
	(49, 'Caipirinha', 3.00, 10.00, 6, 1),
	(50, 'Cuba Libre', 5.00, 15.00, 6, 1),
	(51, 'Mint Gulep', 5.00, 15.00, 7, 1),
	(52, 'Line Margarita', 5.00, 11.00, 10, 1),
	(53, 'Bellini', 10.00, 20.00, 11, 1),
	(54, 'Tequila Sunrise', 10.00, 26.00, 13, 1),
	(55, 'Suco de Laranja', 10.00, 15.00, 5, 3),
	(56, 'teste2', 20.00, 10.00, 2, 2);

-- Copiando estrutura para tabela projeto_bar.produtoporvenda
DROP TABLE IF EXISTS `produtoporvenda`;
CREATE TABLE IF NOT EXISTS `produtoporvenda` (
  `PRODUTO_codProduto` int(11) NOT NULL,
  `VENDA_codVenda` int(11) NOT NULL,
  `quantidade` int(11) NOT NULL,
  PRIMARY KEY (`PRODUTO_codProduto`,`VENDA_codVenda`),
  KEY `fk_PRODUTO_has_VENDA_VENDA1_idx` (`VENDA_codVenda`),
  KEY `fk_PRODUTO_has_VENDA_PRODUTO1_idx` (`PRODUTO_codProduto`),
  CONSTRAINT `fk_PRODUTO_has_VENDA_PRODUTO1` FOREIGN KEY (`PRODUTO_codProduto`) REFERENCES `produto` (`codProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PRODUTO_has_VENDA_VENDA1` FOREIGN KEY (`VENDA_codVenda`) REFERENCES `venda` (`codVenda`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela projeto_bar.produtoporvenda: ~0 rows (aproximadamente)

-- Copiando estrutura para tabela projeto_bar.usuarios
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `idusuarios` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL,
  PRIMARY KEY (`idusuarios`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela projeto_bar.usuarios: ~0 rows (aproximadamente)
INSERT INTO `usuarios` (`idusuarios`, `nome`, `senha`) VALUES
	(3, 'adm', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3');

-- Copiando estrutura para tabela projeto_bar.venda
DROP TABLE IF EXISTS `venda`;
CREATE TABLE IF NOT EXISTS `venda` (
  `codVenda` int(11) NOT NULL AUTO_INCREMENT,
  `mesaVenda` int(10) unsigned NOT NULL,
  `dataHoraVenda` datetime NOT NULL,
  `CLIENTE_codCliente` int(11) NOT NULL,
  PRIMARY KEY (`codVenda`,`CLIENTE_codCliente`),
  KEY `fk_VENDA_CLIENTE1_idx` (`CLIENTE_codCliente`),
  CONSTRAINT `fk_VENDA_CLIENTE1` FOREIGN KEY (`CLIENTE_codCliente`) REFERENCES `cliente` (`codCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela projeto_bar.venda: ~5 rows (aproximadamente)
INSERT INTO `venda` (`codVenda`, `mesaVenda`, `dataHoraVenda`, `CLIENTE_codCliente`) VALUES
	(7, 1, '2022-10-11 00:00:00', 2),
	(10, 10, '2022-10-20 00:00:00', 2),
	(22, 23, '2021-05-05 00:00:00', 4),
	(23, 2, '2022-12-05 00:00:00', 3),
	(24, 8, '2022-05-20 00:00:00', 9);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
