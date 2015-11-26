window.onload = ->
  # zero clipboard
  window.zclip = new ZeroClipboard document.getElementById("copy-thot")

  # sentimood
  window.sentiment = new Sentimood()

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
  monthNo = dateObj.getUTCMonth()
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

  month = monthNames[monthNo]
  d = month + ' ' + day + ', ' + year
  document.getElementById('date-text').innerHTML = d

copyThot = ->
  # organize
  essay = "#{$("#name").val()}\r#{$("#date-text").text()}\r#{$("#title").val()}\n\t#{$("#th").val()}" + "\r\t#{$("#ts1").val()} #{$("#ex1").val()} #{$("#cs1").val()}\r\t" + "#{$("#ts2").val()} #{$("#ex2").val()} #{$("#cs2").val()}\r\t" + "#{$("#ts3").val()} #{$("#ex3").val()} #{$("#cs3").val()}\r\t" + "#{$("#co").val()}"

  zclip.on "copy", (event) =>
    clipboard = event.clipboardData
    clipboard.setData "text/plain", essay

  zclip.on "error", (event) =>
    window.prompt("Copy to clipboard:\nCtrl+C, Enter", essay)

# plaintext
saveText = ->
  # organize
  essay = "#{$("#name").val()}\r\n#{$("#date-text").text()}\r\n#{$("#title").val()}\n\n\t#{$("#th").val()}" + "\r\n\t#{$("#ts1").val()} #{$("#ex1").val()} #{$("#cs1").val()}\r\n\t" + "#{$("#ts2").val()} #{$("#ex2").val()} #{$("#cs2").val()}\r\n\t" + "#{$("#ts3").val()} #{$("#ex3").val()} #{$("#cs3").val()}\r\n\t" + "#{$("#co").val()}"

  # new text file
  save = new Blob [essay], {type: "text/plain;charset=utf-8"}

  # save
  saveAs save, $("#title").val()

# html
saveHtml = ->
  # i reused the save object because it is easier to wrap my head around
  essay =
    head:
      name: $("#name").val() # idk if there is an easier way of doing this but seeing as marked is pretty speedy
      title: $("#title").val() # and i need every paragraph rendered seperately this seems like the best way to go
      date: $("#date-text").text()
    para:
      thesis: marked $("#th").val()
      conclusion: marked $("#co").val()
    bp1:
      marked(
        $("#ts1").val() + " " +
        $("#ex1").val() + " " +
        $("#cs1").val()
      )
    bp2:
      marked(
        $("#ts2").val() + " " +
        $("#ex2").val() + " " +
        $("#cs2").val()
      )
    bp3:
      marked(
        $("#ts3").val() + " " +
        $("#ex3").val() + " " +
        $("#cs3").val()
      )

  # format as html
  essayHTML = "
    <!DOCTYPE html>
    <html lang=\"en\">
      <head>
        <meta charset=\"utf-8\">
        <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">
        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">
        <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
        <title>#{essay.head.title}</title>

        <!-- Bootstrap -->
        <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css\" integrity=\"sha512-dTfge/zgoMYpP7QbHy4gWMEGsbsdZeCXz7irItjcC3sPUFtf0kuFbDz/ixG7ArTxmDjLXDmezHubeNikyKGVyQ==\" crossorigin=\"anonymous\">

        <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
        <!-- WARNING: Respond.js doesn\'t work if you view the page via file:// -->
        <!--[if lt IE 9]>
          <script src=\"https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js\"></script>
          <script src=\"https://oss.maxcdn.com/respond/1.4.2/respond.min.js\"></script>
        <![endif]-->

        <!-- styles -->
        <style>
            .container {
                /* padding */
                padding: 0.5in;

                /* font stuff */
                font-family: \"Times New Roman\", sans-serif;
                font-size: 12pt;
            }

            .title {
                width: 100%;
                text-align: center;
                font-weight: 600;
            }
        </style>
      </head>
      <body>
        <div class=\"container\">
            <p>#{essay.head.name}</p>
            <p>#{essay.head.date}</p>
            <p class=\"title\">#{essay.head.title}</p>

            <p>#{essay.para.thesis}</p>
            <p>#{essay.bp1}</p>
            <p>#{essay.bp2}</p>
            <p>#{essay.bp3}</p>
            <p>#{essay.para.conclusion}</p>
        </div>
      </body>
    </html>"

  # new text file
  save = new Blob [essayHTML], {type: "text/html;charset=utf-8"}

  # save
  saveAs save, $("#title").val() + ".html"

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