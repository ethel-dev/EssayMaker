$ ->
    $('#preview-toggle').change ->
        if $(this).prop("checked") == true
            # preview essay
            essay = "#{$("#name").val()}<br>#{$("#date-text").text()}<br>#{$("#title").val()}<br><br>\t#{$("#th").val()}" + "<br>\t#{$("#ts1").val()} #{$("#ex1").val()} #{$("#cs1").val()}<br>\t" + "#{$("#ts2").val()} #{$("#ex2").val()} #{$("#cs2").val()}<br>\t" + "#{$("#ts3").val()} #{$("#ex3").val()} #{$("#cs3").val()}<br>\t" + "#{$("#co").val()}"
            $("#preview").html(essay)
            
            $("#editor").hide(125)
            $("#preview").show(125)
        else
            $("#preview").hide(125)
            $("#editor").show(125)

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