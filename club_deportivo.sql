-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema club_deportivo
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema club_deportivo
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `club_deportivo` DEFAULT CHARACTER SET utf8mb4 ;
USE `club_deportivo` ;

-- -----------------------------------------------------
-- Table `club_deportivo`.`profesores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`profesores` (
  `id_profesor` INT(11) NOT NULL AUTO_INCREMENT,
  `id_persona` INT(11) NULL DEFAULT NULL,
  `id_cargo` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id_profesor`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `club_deportivo`.`actividades_club`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`actividades_club` (
  `id_actividad_club` INT(11) NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `precio` INT(11) NOT NULL,
  `cant_horas` INT(11) NOT NULL,
  `id_profesor` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id_actividad_club`),
  INDEX `fk_actividad_profesor` (`id_profesor` ASC),
  CONSTRAINT `fk_actividad_profesor`
    FOREIGN KEY (`id_profesor`)
    REFERENCES `club_deportivo`.`profesores` (`id_profesor`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `club_deportivo`.`cargos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`cargos` (
  `id_cargo` INT(11) NOT NULL AUTO_INCREMENT,
  `cargo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_cargo`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COMMENT = '			';


-- -----------------------------------------------------
-- Table `club_deportivo`.`carnets`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`carnets` (
  `id_carnet` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_carnet`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `club_deportivo`.`personas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`personas` (
  `id_persona` INT(11) NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `apellido` VARCHAR(45) NOT NULL,
  `dni` INT(11) NOT NULL,
  PRIMARY KEY (`id_persona`))
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `club_deportivo`.`clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`clientes` (
  `id_cliente` INT(11) NOT NULL AUTO_INCREMENT,
  `id_persona` INT(11) NULL DEFAULT NULL,
  `apto_fisico` TINYINT(4) NOT NULL,
  `es_socio` TINYINT(4) NULL DEFAULT NULL,
  PRIMARY KEY (`id_cliente`),
  INDEX `fk_cliente_persona` (`id_persona` ASC),
  CONSTRAINT `fk_cliente_persona`
    FOREIGN KEY (`id_persona`)
    REFERENCES `club_deportivo`.`personas` (`id_persona`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `club_deportivo`.`socios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`socios` (
  `id_socio` INT(11) NOT NULL AUTO_INCREMENT,
  `id_cliente` INT(11) NULL DEFAULT NULL,
  `estado_suscripcion` TINYINT(4) NOT NULL,
  `id_carnet` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id_socio`),
  INDEX `fk_socio_cliente` (`id_cliente` ASC),
  INDEX `fk_socio_carnet` (`id_carnet` ASC),
  CONSTRAINT `fk_socio_carnet`
    FOREIGN KEY (`id_carnet`)
    REFERENCES `club_deportivo`.`carnets` (`id_carnet`),
  CONSTRAINT `fk_socio_cliente`
    FOREIGN KEY (`id_cliente`)
    REFERENCES `club_deportivo`.`clientes` (`id_cliente`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `club_deportivo`.`cuotas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`cuotas` (
  `id_cuota` INT(11) NOT NULL AUTO_INCREMENT,
  `precio` INT(11) NOT NULL,
  `fecha_vencimiento` DATE NOT NULL,
  `id_socio` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id_cuota`),
  INDEX `fk_cuota_socio` (`id_socio` ASC),
  CONSTRAINT `fk_cuota_socio`
    FOREIGN KEY (`id_socio`)
    REFERENCES `club_deportivo`.`socios` (`id_socio`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `club_deportivo`.`no_socios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`no_socios` (
  `id_no_socio` INT(11) NOT NULL AUTO_INCREMENT,
  `id_cliente` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id_no_socio`),
  INDEX `fk_no_socio_cliente` (`id_cliente` ASC),
  CONSTRAINT `fk_no_socio_cliente`
    FOREIGN KEY (`id_cliente`)
    REFERENCES `club_deportivo`.`clientes` (`id_cliente`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `club_deportivo`.`pagos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`pagos` (
  `id_pago` INT(11) NOT NULL AUTO_INCREMENT,
  `id_cuota` INT(11) NULL DEFAULT NULL,
  `fecha_pago` DATE NOT NULL,
  `estado_pago` TINYINT(4) NOT NULL,
  `modalidad` VARCHAR(45) NOT NULL,
  `cantidad_cuotas` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id_pago`),
  INDEX `fk_pago_cuota` (`id_cuota` ASC),
  CONSTRAINT `fk_pago_cuota`
    FOREIGN KEY (`id_cuota`)
    REFERENCES `club_deportivo`.`cuotas` (`id_cuota`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COMMENT = '		';


-- -----------------------------------------------------
-- Table `club_deportivo`.`usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`usuarios` (
  `id_usuario` INT(11) NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_usuario`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


-- -----------------------------------------------------
-- Se agrega usuario y contrasenia en la tabla usuarios
-- -----------------------------------------------------
INSERT INTO club_deportivo.usuarios (`username`, `password`) VALUES ("usuario", "1234");
