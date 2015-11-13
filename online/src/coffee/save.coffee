window.onload = ->
    # zero clipboard
    window.zclip = new ZeroClipboard document.getElementById("copy-thot")
    
    # sentimood
    window.sentiment = new Sentimood();
    
    # filedrop button
    window.droptions =
        readAsDefault: "Text"
        
        dragClass: "drop"
        
        on:
            load: (e, file) ->
                essay = JSON.parse e.target.result
                
                $("#name").val(essay.head.name)
                $("#title").val(essay.head.title)
                $("#date-text").text(essay.head.date)
                    
                $("#th").val(essay.para.thesis)
                $("#co").val(essay.para.conclusion)
                    
                $("#ts1").val(essay.bp1.ts)
                $("#ex1").val(essay.bp1.ex)
                $("#cs1").val(essay.bp1.cs)
                    
                $("#ts2").val(essay.bp2.ts)
                $("#ex2").val(essay.bp2.ex)
                $("#cs2").val(essay.bp2.cs)
                    
                $("#ts3").val(essay.bp3.ts)
                $("#ex3").val(essay.bp3.ex)
                $("#cs3").val(essay.bp3.cs)
                
                $("#open-from-save").notify("Essay loaded successfully.", "success")
            error: (e, file) ->
                # error handler
                console?.log(e.target.error)
                
                $("#open-from-save").notify("There was an error loading your file.")
            skip: (e, file) ->
                # if file isn't json
                alert "This file could not be read."
    
    FileReaderJS.setupDrop(document.getElementById('open-from-save'), window.droptions)
    
    # weird animation for said filedrop button
    $("#open-from-save").bind "dragenter", ->
        $("#open-from-save").addClass("drop")
        $("#save-text").addClass("pacman-scale").html("<div></div><div></div><div></div><div></div>")
    $("#open-from-save").bind "dragleave", ->
        $("#open-from-save").removeClass("drop")
        $("#save-text").removeClass("pacman-scale").html("Open")
    $("#open-from-save").bind "drop", ->
        $("#open-from-save").removeClass("drop")
        $("#save-text").removeClass("pacman-scale").html("Open")
    
    # initialize tooltips
    $('[data-toggle="tooltip"]').tooltip()
    
    # attempt to use zeroclipboard, but then again nobody likes flash so it probably won't work and i'll scrap it later
    zclip.on "ready", ->
        console?.log "ZeroClipboard is ready!"
    
    # this date code is some old and messy stuff from another abandoned project, i might change it later
    dateObj = new Date
    monthno = dateObj.getUTCMonth()
    day = dateObj.getUTCDate()
    year = dateObj.getUTCFullYear()
    
    monthNames = [
      'January'
      'February'
      'March'
      'April'
      'May'
      'June'
      'July'
      'August'
      'September'
      'October'
      'November'
      'December'
    ]
    
    month = monthNames[monthno]
    d = month + ' ' + day + ', ' + year
    document.getElementById('date-text').innerHTML = d

copyThot =  ->
    # organize
    essay = "#{$("#name").val()}\r#{$("#date-text").text()}\r#{$("#title").val()}\n\t#{$("#th").val()}" + "\r\t#{$("#ts1").val()} #{$("#ex1").val()} #{$("#cs1").val()}\r\t" + "#{$("#ts2").val()} #{$("#ex2").val()} #{$("#cs2").val()}\r\t" + "#{$("#ts3").val()} #{$("#ex3").val()} #{$("#cs3").val()}\r\t" + "#{$("#co").val()}"
    
    zclip.on "copy", (event) =>
        clipboard = event.clipboardData
        clipboard.setData "text/plain", essay
        
    zclip.on "error", (event) =>
        window.prompt("Copy to clipboard:\nCtrl+C, Enter", essay)
        
saveThot = ->
    # organize
    essay = "#{$("#name").val()}\r\n#{$("#date-text").text()}\r\n#{$("#title").val()}\n\n\t#{$("#th").val()}" + "\r\n\t#{$("#ts1").val()} #{$("#ex1").val()} #{$("#cs1").val()}\r\n\t" + "#{$("#ts2").val()} #{$("#ex2").val()} #{$("#cs2").val()}\r\n\t" + "#{$("#ts3").val()} #{$("#ex3").val()} #{$("#cs3").val()}\r\n\t" + "#{$("#co").val()}"
    
    # new text file
    save = new Blob [essay], {type: "text/plain;charset=utf-8"}
    
    # save
    saveAs save, $("#title").val()

saveEssay = ->
    # organize as object
    essay =
        head:
            name: $("#name").val()
            title: $("#title").val()
            date: $("#date-text").text()
        para:
            thesis: $("#th").val()
            conclusion: $("#co").val()
        bp1:
            ts: $("#ts1").val()
            ex: $("#ex1").val()
            cs: $("#cs1").val()
        bp2:
            ts: $("#ts2").val()
            ex: $("#ex2").val()
            cs: $("#cs2").val()
        bp3:
            ts: $("#ts3").val()
            ex: $("#ex3").val()
            cs: $("#cs3").val()
            
    save = new Blob [JSON.stringify(essay)], {type: "application/json;charset=utf-8"}
    
    saveAs save, $("#title").val() + ".esma"
    
openEssay = ->
    FileReaderJS.setupInput(document.getElementById('fileinput'), window.droptions)
    
    $("#fileinput").trigger("click")
    
window.onerror = (e) ->
    if RegExp(/Uncaught SyntaxError: Unexpected token ./g).test(e)
        $.notify("Error:\nThe \"essay\" you tried to load was not an essay. Please stop uploading cat pictures to EssayMaker, it won't do anything but waste your time.", "error")
    