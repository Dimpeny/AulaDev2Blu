-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema agendacontatos
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema agendacontatos
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `agendacontatos` DEFAULT CHARACTER SET utf8 ;
USE `agendacontatos` ;

-- -----------------------------------------------------
-- Table `agendacontatos`.`estado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `agendacontatos`.`estado` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `uf` CHAR(2) NOT NULL,
  `descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agendacontatos`.`contato`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `agendacontatos`.`contato` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(50) NOT NULL,
  `numero_telefonico` VARCHAR(45) NOT NULL,
  `CEP` VARCHAR(45) NOT NULL,
  `numero` INT(11) NOT NULL,
  `rua` VARCHAR(45) NOT NULL,
  `bairro` VARCHAR(45) NOT NULL,
  `cidade` VARCHAR(45) NOT NULL,
  `estado_id` INT NOT NULL,
  `status` ENUM('A', 'I', 'E') NOT NULL DEFAULT 'A' COMMENT 'A- Ativo\nI- Inativo\nE- Excluido',
  PRIMARY KEY (`id`),
  INDEX `fk_contato_Estado_idx` (`estado_id` ) ,
  CONSTRAINT `fk_contato_Estado`
    FOREIGN KEY (`estado_id`)
    REFERENCES `agendacontatos`.`estado` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agendacontatos`.`compromisso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `agendacontatos`.`compromisso` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(45) NOT NULL,
  `data_compromisso` DATE NOT NULL,
  `dia_semana` ENUM('SEG', 'TER', 'QUA', 'QUI', 'SEX', 'SAB', 'DOM') NOT NULL,
  `contato_id` INT NULL,
  `status` ENUM('A', 'I', 'E') NOT NULL DEFAULT 'A' COMMENT 'A- Ativo\nI- Inativo\nE- Excluido',
  PRIMARY KEY (`id`),
  INDEX `fk_compromisso_contato1_idx` (`contato_id` ) ,
  CONSTRAINT `fk_compromisso_contato1`
    FOREIGN KEY (`contato_id`)
    REFERENCES `agendacontatos`.`contato` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `agendacontatos`.`estado`
-- -----------------------------------------------------
START TRANSACTION;
USE `agendacontatos`;
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'AC', 'Acre');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'AL', 'Alagoas');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'AP', 'Amapá');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'AM', 'Amazonas');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'BA', 'Bahia');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'CE', 'Ceará');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'DF', 'Distrito Federal');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'ES', 'Espírito Santo');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'GO', 'Goiás');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'MA', 'Maranhão');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'MT', 'Mato Grosso');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'MS', 'Mato Grosso do Sul');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'MG', 'Minas Gerais');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'PA', 'Pará');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'PB', 'Paraíba');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'PR', 'Paraná');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'PE', 'Pernambuco');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'PI', 'Piauí');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'RJ', 'Rio de Janeiro');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'RN', 'Rio Grande do Norte');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'RS', 'Rio Grande do Sul');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'RO', 'Rondônia');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'RR', 'Roraima');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'SC', 'Santa Catarina');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'SP', 'São Paulo');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'SE', 'Sergipe');
INSERT INTO `agendacontatos`.`estado` (`id`, `uf`, `descricao`) VALUES (DEFAULT, 'TO', 'Tocantins');

COMMIT;


-- -----------------------------------------------------
-- Data for table `agendacontatos`.`contato`
-- -----------------------------------------------------
START TRANSACTION;
USE `agendacontatos`;
INSERT INTO `agendacontatos`.`contato` (`id`, `nome`, `numero_telefonico`, `CEP`, `numero`, `rua`, `bairro`, `cidade`, `estado_id`, `status`) VALUES (DEFAULT, 'Jerbisvaldo', '991449191', '0800991', 12, 'ruandia', 'bairrildo', 'cidadosa', 5, DEFAULT);

COMMIT;


-- -----------------------------------------------------
-- Data for table `agendacontatos`.`compromisso`
-- -----------------------------------------------------
START TRANSACTION;
USE `agendacontatos`;
INSERT INTO `agendacontatos`.`compromisso` (`id`, `descricao`, `data_compromisso`, `dia_semana`, `contato_id`, `status`) VALUES (DEFAULT, 'Varrer Lojinha', '12-12-2022', 'SEG', 1, DEFAULT);
INSERT INTO `agendacontatos`.`compromisso` (`id`, `descricao`, `data_compromisso`, `dia_semana`, `contato_id`, `status`) VALUES (DEFAULT, 'Sujar lojinha', '11-12-2022', '\'SAB\'', NULL, DEFAULT);

COMMIT;

