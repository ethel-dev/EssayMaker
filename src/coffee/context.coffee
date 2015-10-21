titleShow = (type, num) ->
    if type isnt "co" or "th"
        $(".l#{type}#{num}").css("visibility", "visible")
        $(".l#{type}#{num}").collapse("show")
        
        switch num
            when "1"
                $(".l#{type}2, .l#{type}3").css("visibility", "hidden")
                $(".l#{type}2, .l#{type}3").collapse("show")
            when "2"
                $(".l#{type}1, .l#{type}3").css("visibility", "hidden")
                $(".l#{type}1, .l#{type}3").collapse("show")
            when "3"
                $(".l#{type}1, .l#{type}2").css("visibility", "hidden")
                $(".l#{type}1, .l#{type}2").collapse("show")
    else
        $(".l#{type}").collapse("show")


titleHide = (type, num) ->
    if type isnt "co" or "th"
        $(".part-label").collapse("hide")
    else
        $(".l#{type}").collapse("hide")
        
copyThot =  ->
    # organize
    essay = "\t#{$("#th").val()}" + "\r\t#{$("#ts1").val()} #{$("#ex1").val()} #{$("#cs1").val()}\r\t" + "#{$("#ts2").val()} #{$("#ex2").val()} #{$("#cs2").val()}\r\t" + "#{$("#ts3").val()} #{$("#ex3").val()} #{$("#cs3").val()}\r\t" + "#{$("#co").val()}"
    window.prompt("Copy to clipboard: Ctrl+C, Enter", essay)