/*Ejemplo de lenjuage de Definición de datos 
26/08/21*/
CREATE DATABASE ejemplo; -- crear base de datos
USE ejemplo; 
-- Tabla fabrica
CREATE TABLE fabrica(id_fabrica INT PRIMARY KEY,
Nombre VARCHAR(20) NOT NULL,
Ubicacion VARCHAR(50)
);
-- Tabla Productos
CREATE TABLE productos(codigo_producto INT primary key auto_increment,
nombre_producto VARCHAR(20) UNIQUE NOT NULL,
descripcion VARCHAR(50),
precio FLOAT DEFAULT 1.0,
fabrica INT,
FOREIGN KEY(fabrica) REFERENCES fabrica(id_fabrica),
CONSTRAINT precio CHECK(precio>5)
);
-- modificar tabla
ALTER TABLE productos MODIFY precio FLOAT DEFAULT (10);

-- agregar columna columna 
ALTER TABLE productos ADD stock INT DEFAULT 1;

-- Borrar columna
ALTER TABLE fabrica DROP ubicacion;