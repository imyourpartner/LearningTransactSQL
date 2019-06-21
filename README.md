# Aprendiendo Transact-SQL
### Que es una base de datos?

Se define una base de datos como una serie de datos organizados  en tablas y relacionados entre sí, los cuales son recolectados y explotados por los sistemas de información de una empresa o negocio en particular.

-  Tabla: Objeto de almacenamiento perteneciente a una BD. Es una estructura en forma de cuadrante donde se almacenan registros o filas de datos. Cada tabla tiene un nombre único en la BD.
-   Registro: Cada una de las filas de una tabla, esta compuesto por campos o atributos.    
- Campo: Cada uno de los “cajoncitos” de un registro donde se guardan los datos. Cada campo tiene un nombre único para la tabla de la cual forma parte, además es de un tipo (naturaleza) determinado, por tanto no podemos guardar limones en el cajón de las naranjas, en términos informáticos y a modo de ejemplo, no encontraremos un dato alfanumérico (letras y números) en un campo diseñado para guardar datos numéricos. Dedicaremos una lección a los tipos de datos más adelante.

Una tabla es una estructura de datos que organiza los datos en columnas y filas; cada columna es un campo (o atributo) y cada fila, un registro. La intersección de una columna con una fila, contiene un dato específico, un solo valor.

Tabla Estudiantes:

| Campo_ID | Campo_nOMBRE | Campo_APELLIDO | Campo_Edad |
| :------: | :----------: | :------------: | ---------- |
|    1     |    María     |     Pérez      | 25         |
|    2     |     José     |     Rojas      | 38         |
|    3     |    Pedro     |     Navas      | 17         |
|    4     |     Luis     |     Newman     | 22         |
|   ...N   |              |                |            |

Cada registro contiene un dato por cada columna de la tabla.
Cada campo (columna) debe tener un nombre. El nombre del campo hace referencia a la información que almacenará.
Cada campo (columna) también debe definir el tipo de dato que almacenará.

  Cada registro o fila de datos contiene información de un Estudiante. En el ejemplo observamos que la tabla tiene un diseño de cuatro campos y que almacena cuatro registros. El nombre de cada campo viene dado por la fila de encabezado. El dato que contiene el campo Campo_ID identifica cada registro, pero por ahora no le demos importancia a esto.

Los registros o miembros de una tabla tienen en común sus atributos, no el dato en sí, que lo más probable es que difiera de un registro a otro, pero sí el hecho de que todos ellos poseen esos atributos. Por lo tanto las tablas de una BD guardan información de individuos o unidades de una misma naturaleza con una serie de atributos en común.  

### Sistema de Gestión de Base de Datos 

Los Sistemas de Gestión de Base de Datos (en inglés DataBase Management System) son un tipo de software muy específico, dedicado a servir de interfaz entre la base de datos, el usuario y las aplicaciones que la utilizan. Se compone de un lenguaje de definición de datos, de un lenguaje de manipulación de datos y de un lenguaje de consulta.

### Microsoft SQL Server 

Es un sistema de gestión de bases de datos relacionales (SGBD) basado en el lenguaje Transact-SQL, y específicamente en Sybase IQ. Este motor de base de datos admite multitud de usuarios conectados a la base de datos de forma simultánea y concurrent

### SQL

SQL (Structured Query Language), Lenguaje Estructurado de Consulta es el lenguaje utilizado para definir, controlar y acceder a los datos almacenados en una base de datos relacional.

El SQL es un lenguaje universal que se emplea en cualquier sistema gestor de bases de datos relacional. Tiene un estándar definido, a partir del cual cada sistema gestor ha desarrollado su versión propia.

En SQL Server la versión de SQL que se utiliza se llama TRANSACT-SQL.

EL SQL en principio es un lenguaje orientado únicamente a la definición y al acceso a los datos por lo que no se puede considerar como un lenguaje de programación como tal ya que no incluye funcionalidades como son estructuras condicionales, bucles, formateo de la salida, etc. (aunque veremos que esto está evolucionando).

Se puede ejecutar directamente en modo interactivo, pero también se suele emplear embebido en programas escritos en lenguajes de programación convencionales. En estos programas se mezclan las instrucciones del propio lenguaje (denominado anfitrión) con llamadas a procedimientos de acceso a la base de datos que utilizan el SQL como lenguaje de acceso. Como por ejemplo en Visual Basic, Java, C#, PHP .NET, etc.

Las instrucciones SQL se clasifican según su propósito en tres grupos:

- El DDL (Data Description Language) Lenguaje de Descripción de Datos.

  En el **DDL** (acciones **sobre la definición de la base de datos**)

  CREATE (Crear)

  DROP (Eliminar)

  ALTER (Modificar)

- El DCL (Data Control Language) Lenguaje de Control de Datos.

- El DML (Data Manipulation Language) Lenguaje de Manipulación de Datos.

  En el **DML** (acciones **sobre los datos** almacenados) utilizaremos los verbos:

  INSERT (Crear, es decir, insertar una nueva fila de datos)

  DELETE (Eliminar filas de datos)

  UPDATE (Modificar filas de datos)

  SELECT (Seleccionar, obtener)

- El **DDL**, es la parte del SQL dedicada a la definición de la base de datos, consta de sentencias para definir la **estructura** de la base de datos, permiten crear la base de datos, crear, modificar o eliminar la estructura de las tablas, crear índices, definir reglas de validación de datos, relaciones entre las tablas, etc. Permite definir gran parte del nivel interno de la base de datos. Por este motivo estas sentencias serán utilizadas normalmente por el **administrador de la base de datos**.

  

- El **DCL** (Data Control Language) se compone de instrucciones que permiten:
  - Ejercer un control sobre los datos tal como la asignación de privilegios de acceso a los datos (GRANT/REVOKE).
  - La gestión de transacciones (COMMIT/ROLLBACK).

  Una transacción se puede definir como un conjunto de acciones que se tienen que realizar todas o ninguna para preservar la integridad de la base de datos.
  Por ejemplo supongamos que tenemos una base de datos para las reservas de avión. Cuando un usuario pide reservar una plaza en un determinado vuelo, el sistema tiene que comprobar que queden plazas libres, si quedan plazas reservará la que quiera el usuario generando un nuevo billete y marcando la plaza como ocupada. Aquí tenemos un proceso que consta de dos operaciones de actualización de la base de datos (crear una nueva fila en la tabla de billetes y actualizar la plaza reservada en el vuelo, poniéndola como ocupada) estas dos operaciones se tienen que ejecutar o todas o ninguna, si después de crear el billete no se actualiza la plaza porque se cae el sistema, por ejemplo, la base de datos quedaría en un estado inconsistente ya que la plaza constaría como libre cuando realmente habría un billete emitido para esta plaza. En este caso el sistema tiene el mecanismo de transacciones para evitar este error. Las operaciones se incluyen las dos en una misma transacción y así el sistema sabe que las tiene que ejecutar las dos, si por lo que sea no se pueden ejecutar las dos, se encarga de deshacer los cambios que se hubiesen producido para no ejecutar ninguna.

  Las instrucciones que gestionan las autorizaciones serán utilizadas normalmente por el **administrador** mientras que las otras, referentes a proceso de transacciones serán utilizadas también por los **programadores**.

  No todos los sistemas disponen de ellas.

- El **DML** se compone de las instrucciones para el manejo de los datos, para insertar nuevos datos, modificar datos existentes, para eliminar datos y la más utilizada, para recuperar datos de la base de datos. Veremos que una sola instrucción de recuperación de datos es tan potente que permite recuperar datos de varias tablas a la vez, realizar cálculos sobre estos datos y obtener resúmenes.

El DML interactúa con el nivel externo de la base de datos por lo que sus instrucciones son muy parecidas, por no decir casi idénticas, de un sistema a otro, el usuario sólo indica lo que quiere recuperar no cómo se tiene que recuperar, no influye el cómo están almacenados los datos.

Es el lenguaje que utilizan los **programadores** y los **usuarios** de la base de datos.

A lo largo del curso se explicarán cada una de las formas de explotación de la base de datos. Dependiendo de tu perfil profesional (programador o administrador) o de tu interés personal te resultará más útil un bloque u otro.

### Tipos de datos de Microsoft SQL Server

A continuación os mostramos los tipos de datos que se pueden definir para este motor de base de datos (tanto para Microsoft SQL Server como para MSDE):

| **Grupo**                        | **Tipo de dato**                                             | **Intervalo**                                                | **Almacenamiento**       |
| -------------------------------- | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------ |
| Numéricos exactos                | bigint                                                       | De -263(-9.223.372.036.854.775.808) a 263 - 1 (9.223.372.036.854.775.807) | 8 bytes                  |
| int                              | De -231 (-2.147.483.648) a 231 - 1 (2.147.483.647)           | 4 bytes                                                      |                          |
| smallint                         | De -215 (-32.768) a 215 - 1 (32.767)                         | 2 bytes                                                      |                          |
| tinyint                          | De 0 a 255                                                   | 1 byte                                                       |                          |
| bit                              | Tipo de datos entero que puede aceptar los valores 1, 0 ó NULL | 2 bytes                                                      |                          |
| decimal, numeric, decimal (p, s) | *p* (precisión): el número total máximo de dígitos decimales que se puede almacenar, tanto a la izquierda como a la derecha del separador decimal. La precisión debe ser un valor comprendido entre 1 y la precisión máxima de 38. La precisión predeterminada es 18.*s* (escala): el número máximo de dígitos decimales que se puede almacenar a la derecha del separador decimal. La escala debe ser un valor comprendido entre 0 y *p*. Sólo es posible especificar la escala si se ha especificado la precisión. La escala predeterminada es 0.Con precisión máxima 1038 +1 y 1038 - 1 | Precisión 1 - 9: 5 bytes                                     |                          |
| money                            | Tipos de datos que representan valores monetarios o de moneda: de -922.337.203.685,4775808 a 922.337.203.685,4775807 | 8 bytes                                                      |                          |
| smallmoney                       | De - 214,7483648 a 214,7483647                               | 4 bytes                                                      |                          |
| Numéricos aproximados            | float                                                        | De - 1,79E+308 a -2,23E-308, 0 y de 2,23E-308 a 1,79E+308    | Depende del valor de *n* |
| real                             | De - 3,40E + 38 a -1,18E - 38, 0 y de 1,18E - 38 a 3,40E + 38 | 4 Bytes                                                      |                          |
| Fecha y hora                     | datetime                                                     | Del 1 de enero de 1753 hasta el 31 de diciembre de 9999      |                          |
| smalldatetime                    | Del 1 de enero de 1900 hasta el 6 de junio de 2079           |                                                              |                          |
| Cadenas de caracteres            | char (n)                                                     | Caracteres no Unicode de longitud fija, con una longitud de *n* bytes. *n*debe ser un valor entre 1 y 8.000 | n bytes                  |
| varchar (n)                      | Caracteres no Unicode de longitud variable. *n* indica que el tamaño de almacenamiento máximo es de 231- 1 bytes | n bytes (aprox.)                                             |                          |
| text                             | En desuso, sustituido por *varchar*.Datos no Unicode de longitud variable con una longitud máxima de 231 - 1 (2.147.483.647) caracteres | max bytes (aprox.)                                           |                          |
| Cadenas de caracteres unicode    | nchar (n)                                                    | Datos de carácter Unicode de longitud fija, con *n* caracteres. *n*debe estar comprendido entre 1 y 4.000 | 2 * n bytes              |
| nvarchar (n)                     | Datos de carácter Unicode de longitud variable. *n* indica que el tamaño máximo de almacenamiento es 231 - 1 bytes | 2 * n bytes + 2 bytes                                        |                          |
| ntext (n)                        | En desuso, sustituido por *nvarchar*.Datos Unicode de longitud variable con una longitud máxima de 230 - 1 (1.073.741.823) caracteres | 2 * n bytes                                                  |                          |
| Cadenas binarias                 | binary (n)                                                   | Datos binarios de longitud fija con una longitud de *n* bytes, donde *n* es un valor que oscila entre 1 y 8.000 | *n* bytes                |
| varbinary (n)                    | Datos binarios de longitud variable. n indica que el tamaño de almacenamiento máximo es de 231- 1 bytes | n bytes                                                      |                          |
| image                            | En desuso, sustituido por *varbinary*.Datos binarios de longitud variable desde 0 hasta 231 - 1 (2.147.483.647) bytes |                                                              |                          |
| Otros tipos de datos             | cursor                                                       | Tipo de datos para las variables o para los parámetros de resultado de los procedimientos almacenados que contiene una referencia a un cursor. Las variables creadas con el tipo de datos *cursor* aceptan NULL |                          |
| timestamp                        | Tipo de datos que expone números binarios únicos generados automáticamente en una base de datos. El tipo de datos *timestamp*es simplemente un número que se incrementa y no conserva una fecha o una hora | 8 bytes                                                      |                          |
| sql_variant                      | Tipo de datos que almacena valores de varios tipos de datos aceptados en SQL Server, excepto *text*, *ntext*, *image*, *timestamp* y *sql_variant* |                                                              |                          |
| uniqueidentifier                 | Es un GUID (Globally Unique Identifier, Identificador Único Global) | 16 bytes                                                     |                          |
| table                            | Es un tipo de datos especial que se puede utilizar para almacenar un conjunto de resultados para su procesamiento posterior. *table* se utiliza principalmente para el almacenamiento temporal de un conjunto de filas devuelto como el conjunto de resultados de una función con valores de tabla |                                                              |                          |
| xml                              | Almacena datos de XML. Puede almacenar instancias de xml en una columna o una variable de tipo xml |                                                              |                          |

### Microsoft Transact-SQL

Para aclarar algunas instrucciones o documentar codigo, en ocasiones, necesitamos agregar comentarios.
Es posible ingresar comentarios en la línea de comandos, es decir, un texto que no se ejecuta; para ello se emplean dos guiones (--) al comienzo de la línea:

```mssql
 SELECT * FROM Estudiantes -- Esto es un comentario
 SELECT * FROM Empleados /* Otra Forma de realizar comentarios*/
```

en la línea anterior, todo lo que está luego de los guiones (hacia la derecha) no se ejecuta.

Para agregar varias líneas de comentarios, se coloca una barra seguida de un asterisco (/*) al comienzo del bloque de comentario y al finalizarlo, un asterisco seguido de una barra (*/).

### Crear base de datos

```mssql
CREATE DATABASE NombreDeMiBaseDeDatos;
```



### Borrar base de datos

```mssql
DROP DATABASE NombreDeMiBaseDeDatos;
```

### Crear tabla

Cada campo con su tipo debe separarse con comas de los siguientes, excepto el último.

```mssql
CREATE TABLE NombreDeLaTabla(
    NombreDelCampo1 TIPODEDATO(TamañoDelDato),
    NombreDelCampo2 TIPODEDATO(TamañoDelDato),
    NombreDelCampo3 TIPODEDATO(TamañoDelDato),
    NombreDelCampoN TIPODEDATO
);
```

```mssql
CREATE TABLE Estudiante(
    Nombre VARCHAR(20),
    Apellido VARCHAR(20),
    Edad TINYINT
);
```

### Insertar Registros

```mssql
INSERT INTO NombreDeLaTabla(NombreDelCampo1,NombreDelCampo2,NombreDelCampo3) 
VALUES ('valorCampo1', 'valorCampo1', 'valorCampo1');
```

```mssql
INSERT INTO Estudiantes (Nombre,Apellido,Edad) 
VALUES ('Mario', 'Rojas', '23');

INSERT INTO Estudiantes (Nombre,Apellido,Edad) 
VALUES ('Jose', 'Perez', '32');

INSERT INTO Estudiantes (Nombre,Apellido,Edad) 
VALUES ('Maria', 'De Freitas', '55');
```

### Consultar Registros

```mssql
SELECT Campo1,Campo2 FROM NombreDeLaTabla;
```

```mssql
SELECT Nombre,Apellido FROM Estudiantes;
```

Para seleccionar todos los campos de una tabla se usa el operador *

```mssql
SELECT * FROM Estudiantes;
```

Resultado:

| Nombre |  Apellido  | Edad |
| :----: | :--------: | :--: |
| Mario  |   Rojas    |  23  |
|  Jose  |   Perez    |  32  |
| Maria  | De Freitas |  55  |

### Borrar Tabla

```mssql
DROP TABLE NombreDeLaTabla;
```

### WHERE

Hemos aprendido a seleccionar algunos campos de una tabla.
También es posible recuperar algunos registros.

Existe una cláusula, "where" con la cual podemos especificar condiciones para una consulta "select". Es decir, podemos recuperar algunos registros, sólo los que cumplan con ciertas condiciones indicadas con la cláusula "where". Por ejemplo, queremos ver el usuario cuyo nombre es "Maria", para ello utilizamos "where" y luego de ella, la condición:

```mssql
SELECT Campo1,Campo2 FROM NombreDeLaTabla
WHERE Condicion;
```

Ejemplo 1)

Traerá como condición todos los registros que tenga  nombre María

```mssql
SELECT Nombre,Apellido,Edad FROM Estudiantes
WHERE Nombre = 'Maria';
```

Resultado:

| Nombre |  Apellido  | Edad |
| :----: | :--------: | :--: |
| Maria  | De Freitas |  55  |



Ejemplo 2)

Selecciona todos los campos de la tabla estudiantes donde el estudiante sea menor a 50 años

```mssql
SELECT * from Estudiantes
WHERE Edad < 50;
```

| Nombre | Apellido | Edad |
| :----: | :------: | :--: |
| Mario  |  Rojas   |  23  |
|  Jose  |  Perez   |  32  |

### DELETE

Para eliminar todos los  registros de una tabla usamos el comando "delete":

```mssql
DELETE FROM NombreDeLaTabla;
```

Para eliminar determino registro debe usar un condicional 

```mssql
DELETE FROM Estudiantes
WHERE Nombre = 'Mario';
```

### UPDATE

Para modificar uno o varios datos de uno o varios registros utilizamos la palabra reservada "update"

Actualiza la Edad a '29' a todos los registro que tengan como nombre Jose

```mssql
UPDATE Estudiantes SET Edad= '29'
WHERE Nombre = 'Jose';
```

### Valores Null

"null" significa "dato desconocido" o "valor inexistente". No es lo mismo que un valor "0", una cadena vacía o una cadena literal "null".

A veces, puede desconocerse o no existir el dato correspondiente a algún campo de un registro. En estos casos decimos que el campo puede contener valores nulos.

Por ejemplo, en nuestra tabla de libros, podemos tener valores nulos en el campo "precio" porque es posible que para algunos libros no le hayamos establecido el precio para la venta.

En contraposición, tenemos campos que no pueden estar vacíos jamás.

Veamos un ejemplo. Tenemos nuestra tabla "libros". El campo "titulo" no debería estar vacío nunca, igualmente el campo "autor". Para ello, al crear la tabla, debemos especificar que dichos campos no admitan valores nulos:

```mssql
 CREATE TABLE Libros(
    Titulo varchar(30) not null, -- No Acepta Valores Nulls
    Autor varchar(20) not null, -- No Acepta Valores Nulls
    Editorial varchar(15) null,
    Precio float -- Si no se declara por defecto acepta valores nulls
 );
INSERT INTO Libros(Titulo,Autor,Editorial,Precio)
VALUES('Don Quijote de la Mancha', 'Miguel de Cervantes Saavedra', 'Francisco de Robles', '30000'),
```

Si se intenta almacenar un valor null en un campo donde su propiedad esta definada como " NOT NULL" dara como mensaje de error:

```mssql
INSERT INTO Libros(Titulo,Autor,Editorial,Precio)
VALUES(null, 'Miguel de Cervantes Saavedra', 'Francisco de Robles', '30000');
```

```
Cannot insert the value NULL into column 'Titulo', table 'MiBaseDeDatos.dbo.Libros'; 
column does not allow nulls. INSERT fails.
La columna no permite nulos. La inserción a fallado
```

Para ver cuáles campos admiten valores nulos y cuáles no, empleamos el procedimiento almacenado "sp_columns":

```mssql
 exec sp_columns libros;
```

###  Primary Key

Una clave primaria es un campo (o varios) que identifica un solo registro (fila) en una tabla. Para un valor del campo clave existe solamente un registro.