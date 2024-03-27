## <h1 align="center"> Abril Clinica Project </h1>

The windows form project "Abril Clinica" is a database management system that uses SQL Server to recreate the software of a medical clinic

## :electric_plug: Functionalities

The Abril clinica project simulates the software of a medical clinic, in which administrators are allowed to take patient records, delete them from the system and modify their data. In turn, it allows patients to make appointments, see their pending appointments and see available doctors.

The system supports two roles: administrator and patient. Administrators manage patients and appointments, and patients only manage their appointments.

Patients cannot make appointments if they are not registered in the system by administrators.

Administrators can generate CSV or JSON files of both existing patients and appointments.

## :construction: Configuration and execution

To execute the project, you have to run the file `AbrilClinica.UI`.

Inside the resources folder, there is a file called `script.sql` that contains the database structure. We must run it in our database manager to create the database and its tables, and thus be able to perform the queries.

We must create the `CONNECTION_STRING_AC` environment variable with the connection string to be able to establish the connection to the database.