# Integrantes

Victor Mateo Alcócer López - 25010188
EDDY ALFONSO ALMENDAREZ RUIZ

# Biblioteca Digital Estudiantil

Aplicación de consola en C# (.NET Framework 4.8) que demuestra distintos algoritmos de búsqueda sobre una colección de libros.



## Características
- Búsqueda lineal por título (subcadenas, sin distinción de mayúsculas).
- Búsqueda binaria de autores (lista ordenada y sin duplicados).
- Identificación del libro más reciente y el más antiguo.
- Búsqueda por coincidencias de palabra clave en la descripción.

## Estructura
- Models/Libro: Entidad principal (Título, Autor, Año, Descripción).
- Datos/DatosIniciales: Fuente estática de datos (lista inicial de libros).
- Servicios:
  - BuscadorLineal
  - BuscadorBinario
  - BuscadorFecha
  - BuscadorDescripcion
- Program: Menú principal de interacción.

## Requisitos
- Visual Studio 2022
- .NET Framework 4.8
- C# 7.3

## Ejecución
1. Compilar el proyecto (__Build__).
2. Ejecutar con __Start Without Debugging__ o __Start__.
3. Usar el menú numérico para seleccionar opciones.
4. Clonar el siguiente repositorio para ejecutar https://github.com/Zoeloi/CasodeEstudioDuo.git
## Ejemplo de uso
Opción 1: Ingrese parte del título (ej: "Quijote") → muestra coincidencia.
Opción 2: Ingrese autor exacto (ej: "Gabriel García Márquez") → búsqueda binaria.
Opción 4: Palabra clave (ej: "IA") → lista libros con esa palabra en descripción.

## Notas técnicas
- Búsqueda lineal: O(n).
- Búsqueda binaria: O(log n) tras ordenar autores.
- Selección de extremos (más reciente/antiguo): O(n).
- Coincidencias en descripción con Contains (ToLower invariant).

## Drive Victor
https://drive.google.com/drive/folders/1GLDmlvcFNG6OVjO2dHzKESd4RQGl8Tk-?usp=drive_link
