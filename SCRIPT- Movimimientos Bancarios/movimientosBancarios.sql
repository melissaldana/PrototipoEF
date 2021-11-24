-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema examenfinal
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema examenfinal
-- -----------------------------------------------------
CREATE DATABASE examenFinal;
USE examenFinal;

-- -----------------------------------------------------
-- Table `examenfinal`.`banco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `examenfinal`.`banco` (
  `pkIdBanco` VARCHAR(15) NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `direccion` VARCHAR(45) NULL,
  `estado` VARCHAR(45) NULL,
  PRIMARY KEY (`pkIdBanco`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `examenfinal`.`cuentaBancaria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `examenfinal`.`cuentaBancaria` (
  `pkIdcuenta` VARCHAR(15) NOT NULL,
  `cuenta` VARCHAR(45) NULL,
  `usuario` VARCHAR(45) NULL,
  `fechaApertura` DATETIME NULL,
  `estado` VARCHAR(45) NULL,
  PRIMARY KEY (`pkIdcuenta`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `examenfinal`.`cuentaContable`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `examenfinal`.`cuentaContable` (
  `pkIdCuentaContable` VARCHAR(15) NOT NULL,
  `tipoCuenta` VARCHAR(45) NULL,
  `naturaleza` VARCHAR(45) NULL,
  `estado` VARCHAR(45) NULL,
  `cuentaContablecol` VARCHAR(45) NULL,
  PRIMARY KEY (`pkIdCuentaContable`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `examenfinal`.`tipoMovimiento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `examenfinal`.`tipoMovimiento` (
  `pkIdtipoMovimiento` VARCHAR(15) NOT NULL,
  `fkIdCuentaContable` VARCHAR(15) NULL,
  `nombre` VARCHAR(45) NULL,
  `descripcion` VARCHAR(45) NULL,
  `estado` VARCHAR(45) NULL,
  PRIMARY KEY (`pkIdtipoMovimiento`),
  INDEX `fk_tipoMovimiento_cuentaContable1_idx` (`fkIdCuentaContable` ASC) VISIBLE,
  CONSTRAINT `fk_tipoMovimiento_cuentaContable1`
    FOREIGN KEY (`fkIdCuentaContable`)
    REFERENCES `examenfinal`.`cuentaContable` (`pkIdCuentaContable`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `examenfinal`.`movimientosBancarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `examenfinal`.`movimientosBancarios` (
  `pkIdMovimientosBancarios` VARCHAR(15) NOT NULL,
  `fkIdBanco` VARCHAR(15) NOT NULL,
  `fkIdcuenta` VARCHAR(15) NOT NULL,
  `tipoMovimiento_pkIdtipoMovimiento` VARCHAR(15) NOT NULL,
  `fechaEmision` DATETIME NULL,
  `fechaVencimiento` DATETIME NULL,
  `concepto` VARCHAR(45) NULL,
  `valor` VARCHAR(45) NULL,
  `estado` VARCHAR(45) NULL,
  PRIMARY KEY (`pkIdMovimientosBancarios`),
  INDEX `fk_movimientosBancarios_banco1_idx` (`fkIdBanco` ASC) VISIBLE,
  INDEX `fk_movimientosBancarios_cuentaBancaria1_idx` (`fkIdcuenta` ASC) VISIBLE,
  INDEX `fk_movimientosBancarios_tipoMovimiento1_idx` (`tipoMovimiento_pkIdtipoMovimiento` ASC) VISIBLE,
  CONSTRAINT `fk_movimientosBancarios_banco1`
    FOREIGN KEY (`fkIdBanco`)
    REFERENCES `examenfinal`.`banco` (`pkIdBanco`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_movimientosBancarios_cuentaBancaria1`
    FOREIGN KEY (`fkIdcuenta`)
    REFERENCES `examenfinal`.`cuentaBancaria` (`pkIdcuenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_movimientosBancarios_tipoMovimiento1`
    FOREIGN KEY (`tipoMovimiento_pkIdtipoMovimiento`)
    REFERENCES `examenfinal`.`tipoMovimiento` (`pkIdtipoMovimiento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
