========================
Diseño de la Aplicación
========================
El archivo DiagramaArquitectura muestra un diseño de primer orden de la aplicación.

==================
Pipelines (DevOps)
==================
El archivo pipelinecicd.yml seria un ejemplo de cómo implantar le frontend (Ract TS) en la nube mediante un Pipeline con GitHub.
Explicación de cada paso:
build-and-test:

Checkout code: Usa la acción actions/checkout para obtener el código fuente en el entorno de ejecución.
Setup Node.js: Configura el entorno de Node.js (ajusta la versión si es necesario).
Install dependencies: Ejecuta npm install para instalar las dependencias del proyecto.
Run tests: Corre las pruebas con npm test.
versioning:

Bump version and push tag: Usa anothrNick/github-tag-action para crear una nueva versión automáticamente cada vez que se ejecuta en la rama principal (main). Ajusta el default_bump para definir si quieres que el aumento sea patch, minor o major.
Generate Changelog: Usa mikepenz/release-changelog-builder-action para generar un changelog automáticamente basado en los commits. Puedes personalizar el archivo .github/changelog-config.yml para controlar el formato.
deploy:

=======
Backend
=======
Dentro de la carpeta Back hay una solución llamada "madachiecommerce" construida en .NET 8  que implementada una WebAPI busando los conceptos de arquitectura limpia explicados por Robert C. Martin.

========
Frontend
========
Dentro de la carpeta Front hay una aplicación web construida con React y Typescript, usando las mejores practicas, según la comunidad de desarrolladores, para soluciones web.

==================
Base de Datos
==================
El archivo DiagramaBaseDeDatos muestra un Diagrama Relacional de la Base De Datos implementada.
