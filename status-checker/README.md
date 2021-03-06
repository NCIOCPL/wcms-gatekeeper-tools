The status checker is a tool for calling the GateKeeper web service and retrieving the processing status
of documents in a given publishing job.

The specific GateKeeper instance to access is specified via the configuration file.

# Inputs:

## Source:
*	*CDR*		 - Requests submitted by the CDR.
*	*GateKeper Import* - Requests loaded via the GateKeeper admin tool.
*	*GateKeeper*	 - Requests created by the "Reprocess All Documents" mechanism.
*	*Web Service Test* - Requests loaded by the GateKeeper testing tool.

## External ID:
	The request's external ID.  (From the admin tool's Request History page.)

## Report Type:
	Summary - All the documents in a given request
	DocumentLocation - Current processing status of the most recent version of all documents.



Output is an XML document.