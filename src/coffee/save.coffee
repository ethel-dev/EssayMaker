window.onload = ->
    # zero clipboard
    window.zclip = new ZeroClipboard document.getElementById("copy-thot")
    
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
    essay = "\t#{$("#th").val()}" + "\r\t#{$("#ts1").val()} #{$("#ex1").val()} #{$("#cs1").val()}\r\t" + "#{$("#ts2").val()} #{$("#ex2").val()} #{$("#cs2").val()}\r\t" + "#{$("#ts3").val()} #{$("#ex3").val()} #{$("#cs3").val()}\r\t" + "#{$("#co").val()}"
    
    zclip.on "copy", (event) =>
        clipboard = event.clipboardData
        clipboard.setData "text/plain", essay
        
    zclip.on "error", (event) =>
        window.prompt("Copy to clipboard:\nCtrl+C, Enter", essay)