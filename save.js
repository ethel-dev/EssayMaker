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
	document.getElementsByName("topicsentence1")[0].innerHTML = "";
	document.getElementsByName("topicsentence2")[0].innerHTML = "";
	document.getElementsByName("topicsentence3")[0].innerHTML = "";
	
	document.getElementsByName("examples1")[0].innerHTML = "";
	document.getElementsByName("examples2")[0].innerHTML = "";
	document.getElementsByName("examples3")[0].innerHTML = "";
	
	document.getElementsByName("concludingsentence1")[0].innerHTML = "";
	document.getElementsByName("concludingsentence2")[0].innerHTML = "";
	document.getElementsByName("concludingsentence3")[0].innerHTML = "";
	
	document.getElementsByName("conclusion")[0].innerHTML = "";
	document.getElementsByName("thesis")[0].innerHTML = "";
}
}
