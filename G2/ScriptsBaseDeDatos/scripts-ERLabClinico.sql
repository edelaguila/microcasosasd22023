-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema laboratorioclinico
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema laboratorioclinico
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `laboratorioclinico` DEFAULT CHARACTER SET utf8mb3 ;
USE `laboratorioclinico` ;

-- -----------------------------------------------------
-- Table `laboratorioclinico`.`TB_EXPEDIENTE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `laboratorioclinico`.`TB_EXPEDIENTE` (
  `codigo_ex` INT NOT NULL AUTO_INCREMENT,
  `nombre_ex` VARCHAR(30) NOT NULL,
  `genero_ex` VARCHAR(20) NOT NULL,
  `telefono_ex` VARCHAR(10) NOT NULL,
  `nit_ex` VARCHAR(9) NULL DEFAULT NULL,
  `direccion_ex` VARCHAR(50) NULL DEFAULT NULL,
  `referente_ex` VARCHAR(30) NULL DEFAULT NULL,
  `muestra_ex` VARCHAR(25) NULL DEFAULT NULL,
  `nacimiento_ex` DATE NOT NULL,
  `codauxiliar_ex` INT NULL DEFAULT NULL,
  `dpi_ex` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`codigo_ex`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `laboratorioclinico`.`TB_ENCABEZADO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `laboratorioclinico`.`TB_ENCABEZADO` (
  `codigo_en` INT NOT NULL AUTO_INCREMENT,
  `nombre_lab` VARCHAR(30) NOT NULL,
  `codigo_lab` INT NOT NULL,
  `monto_en` DOUBLE NOT NULL,
  PRIMARY KEY (`codigo_en`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `laboratorioclinico`.`TB_FACTURA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `laboratorioclinico`.`TB_FACTURA` (
  `fecha_fa` DATE NOT NULL,
  `codigo_fa` INT NOT NULL AUTO_INCREMENT,
  `TB_EXPEDIENTE_codigo_ex` INT NOT NULL,
  `TB_ENCABEZADO_codigo_en` INT NOT NULL,
  `tipodescuento_fa` VARCHAR(20) NULL,
  PRIMARY KEY (`codigo_fa`),
  INDEX `fk_TB_FACTURA_TB_EXPEDIENTE1_idx` (`TB_EXPEDIENTE_codigo_ex` ASC) VISIBLE,
  INDEX `fk_TB_FACTURA_TB_ENCABEZADO1_idx` (`TB_ENCABEZADO_codigo_en` ASC) VISIBLE,
  CONSTRAINT `fk_TB_FACTURA_TB_EXPEDIENTE1`
    FOREIGN KEY (`TB_EXPEDIENTE_codigo_ex`)
    REFERENCES `laboratorioclinico`.`TB_EXPEDIENTE` (`codigo_ex`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TB_FACTURA_TB_ENCABEZADO1`
    FOREIGN KEY (`TB_ENCABEZADO_codigo_en`)
    REFERENCES `laboratorioclinico`.`TB_ENCABEZADO` (`codigo_en`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `laboratorioclinico`.`TB_CUERPO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `laboratorioclinico`.`TB_CUERPO` (
  `nit_ex` VARCHAR(9) NOT NULL,
  `direccion_ex` VARCHAR(50) NOT NULL,
  `telefono_ex` VARCHAR(10) NOT NULL,
  `nombre_ex` VARCHAR(30) NOT NULL,
  `referente_ex` VARCHAR(30) NOT NULL,
  `tb_factura_codigo_fa` INT NOT NULL,
  INDEX `fk_tb_cuerpo_tb_factura_idx` (`tb_factura_codigo_fa` ASC) VISIBLE,
  CONSTRAINT `fk_tb_cuerpo_tb_factura`
    FOREIGN KEY (`tb_factura_codigo_fa`)
    REFERENCES `laboratorioclinico`.`TB_FACTURA` (`codigo_fa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `laboratorioclinico`.`TB_LABORATORIO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `laboratorioclinico`.`TB_LABORATORIO` (
  `codigo_lab` INT NOT NULL AUTO_INCREMENT,
  `nombre_lab` VARCHAR(30) NOT NULL,
  `TB_EXPEDIENTE_codigo_ex` INT NOT NULL,
  PRIMARY KEY (`codigo_lab`),
  INDEX `fk_TB_LABORATORIO_TB_EXPEDIENTE1_idx` (`TB_EXPEDIENTE_codigo_ex` ASC) VISIBLE,
  CONSTRAINT `fk_TB_LABORATORIO_TB_EXPEDIENTE1`
    FOREIGN KEY (`TB_EXPEDIENTE_codigo_ex`)
    REFERENCES `laboratorioclinico`.`TB_EXPEDIENTE` (`codigo_ex`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `laboratorioclinico`.`TB_USUARIOS`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `laboratorioclinico`.`TB_USUARIOS` (
  `id_us` INT NOT NULL AUTO_INCREMENT,
  `nombre_us` VARCHAR(30) NOT NULL,
  `contrasenia_us` VARCHAR(25) NOT NULL,
  `rol_us` VARCHAR(20) NOT NULL,
  `codigo_ex` INT NOT NULL,
  `TB_EXPEDIENTE_codigo_ex` INT NOT NULL,
  PRIMARY KEY (`id_us`, `TB_EXPEDIENTE_codigo_ex`),
  INDEX `fk_TB_USUARIOS_TB_EXPEDIENTE1_idx` (`TB_EXPEDIENTE_codigo_ex` ASC) VISIBLE,
  CONSTRAINT `fk_TB_USUARIOS_TB_EXPEDIENTE1`
    FOREIGN KEY (`TB_EXPEDIENTE_codigo_ex`)
    REFERENCES `laboratorioclinico`.`TB_EXPEDIENTE` (`codigo_ex`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `laboratorioclinico`.`TB_COTIZACION`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `laboratorioclinico`.`TB_COTIZACION` (
  `id_co` INT NOT NULL AUTO_INCREMENT,
  `nombre_lab` VARCHAR(30) NULL,
  `monto_en` DOUBLE NULL,
  `TB_COTIZACIONcol` VARCHAR(45) NULL,
  `TB_ENCABEZADO_codigo_en` INT NOT NULL,
  `TB_LABORATORIO_codigo_lab` INT NOT NULL,
  PRIMARY KEY (`id_co`),
  INDEX `fk_TB_COTIZACION_TB_ENCABEZADO1_idx` (`TB_ENCABEZADO_codigo_en` ASC) VISIBLE,
  INDEX `fk_TB_COTIZACION_TB_LABORATORIO1_idx` (`TB_LABORATORIO_codigo_lab` ASC) VISIBLE,
  CONSTRAINT `fk_TB_COTIZACION_TB_ENCABEZADO1`
    FOREIGN KEY (`TB_ENCABEZADO_codigo_en`)
    REFERENCES `laboratorioclinico`.`TB_ENCABEZADO` (`codigo_en`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TB_COTIZACION_TB_LABORATORIO1`
    FOREIGN KEY (`TB_LABORATORIO_codigo_lab`)
    REFERENCES `laboratorioclinico`.`TB_LABORATORIO` (`codigo_lab`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
