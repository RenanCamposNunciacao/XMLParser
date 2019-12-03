Library that recceives a XML File Stream and parses it into a desired C# Object.

A console application was also created in order to test the library.

The application will read the InputFile.xml and print out the RefText values for the References with the following RefCodes: ‘MWB’, ‘TRV’ and ‘CAR’


----------------------------------------------------------------------------------------------------------------------------------------------

The WebAPI is responsible for receiving a XML payload and validating if the data passed is correct or not.

- If the XML document given is correct then the value 0 is returned.

- If the Command value is not equal to ‘DEFAULT’ then the value -1 is returned.

- If the SiteID value is not equal to ‘DUB’ then the value -2 is returned.

A PostMan collection with the 3 possibbilities is included in the reposository, on the file InputDocumentAPI.postman_collection.json
