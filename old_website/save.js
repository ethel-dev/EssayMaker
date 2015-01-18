function copyToClipboard() {
	var now = new Date();
	var element1 = (
		document.getElementsByName("topicsentence1")[0].value + ' ' +
		document.getElementsByName("examples1")[0].value + ' ' +
		document.getElementsByName("concludingsentence1")[0].value
		+ '\n'
	);
	var element2 = (
		document.getElementsByName("topicsentence2")[0].value + ' ' +
		document.getElementsByName("examples2")[0].value + ' ' +
		document.getElementsByName("concludingsentence2")[0].value
		+ '\n'
	);
	var element3 = (
		document.getElementsByName("topicsentence3")[0].value + ' ' +
		document.getElementsByName("examples3")[0].value + ' ' +
		document.getElementsByName("concludingsentence3")[0].value
		+ '\n'
	);
	var allElements = (
		document.getElementsByName("name")[0].value + '\n' +
		document.getElementsByName("teachername")[0].value + ' ' + '\n' +
		now + '\n' +
		document.getElementsByName("thesis")[0].value + '\n' +
		element1 + '\n' +
		element2 + '\n' +
		element3 + '\n' +
		document.getElementsByName("conclusion")[0].value
	);
	window.prompt("Copy to clipboard: Ctrl+C, Enter", allElements);
}
function clearThePage() {
	document.getElementsByName("topicsentence1")[0].value = "";
	document.getElementsByName("topicsentence2")[0].value = "";
	document.getElementsByName("topicsentence3")[0].value = "";
	
	document.getElementsByName("examples1")[0].value = "";
	document.getElementsByName("examples2")[0].value = "";
	document.getElementsByName("examples3")[0].value = "";
	
	document.getElementsByName("concludingsentence1")[0].value = "";
	document.getElementsByName("concludingsentence2")[0].value = "";
	document.getElementsByName("concludingsentence3")[0].value = "";
	
	document.getElementsByName("conclusion")[0].value = "";
	document.getElementsByName("thesis")[0].value = "";
}
function saveJs() {
	var now = new Date();
	var element1 = (
		document.getElementsByName("topicsentence1")[0].value + ' ' +
		document.getElementsByName("examples1")[0].value + ' ' +
		document.getElementsByName("concludingsentence1")[0].value
		+ '\n'
	);
	var element2 = (
		document.getElementsByName("topicsentence2")[0].value + ' ' +
		document.getElementsByName("examples2")[0].value + ' ' +
		document.getElementsByName("concludingsentence2")[0].value
		+ '\n'
	);
	var element3 = (
		document.getElementsByName("topicsentence3")[0].value + ' ' +
		document.getElementsByName("examples3")[0].value + ' ' +
		document.getElementsByName("concludingsentence3")[0].value
		+ '\n'
	);
	var allElements = (
		document.getElementsByName("name")[0].value + '\n' +
		document.getElementsByName("teachername")[0].value + ' ' + '\n' +
		now + '\n' +
		document.getElementsByName("thesis")[0].value + '\n' +
		element1 + '\n' +
		element2 + '\n' +
		element3 + '\n' +
		document.getElementsByName("conclusion")[0].value
	);
	// Save script provided by This Could be Better (https://thiscouldbebetter.wordpress.com/2012/12/18/loading-editing-and-saving-a-text-file-in-html5-using-javascrip/)
	var textToWrite = allElements;
	var textFileAsBlob = new Blob([textToWrite], {type:'text/plain'});
	var fileNameToSaveAs = document.getElementById("inputFileNameToSaveAs").value;

	var downloadLink = document.createElement("a");
	downloadLink.download = fileNameToSaveAs;
	downloadLink.innerHTML = "Download File";
	if (window.webkitURL != null)
	{
		// Chrome allows the link to be clicked
		// without actually adding it to the DOM.
		downloadLink.href = window.webkitURL.createObjectURL(textFileAsBlob);
	}
	else
	{
		// Firefox requires the link to be added to the DOM
		// before it can be clicked.
		downloadLink.href = window.URL.createObjectURL(textFileAsBlob);
		downloadLink.onclick = destroyClickedElement;
		downloadLink.style.display = "none";
		document.body.appendChild(downloadLink);
	}

	downloadLink.click();
}
