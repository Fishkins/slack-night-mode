/* AGENT_SHEET */
@-moz-document url-prefix(http://), url-prefix(https://), url-prefix(ftp://), url-prefix(file://), url(about:blank), 

/* Best effort to exclude about pages that conflict with Australis-native styling   */
regexp("about:(?!addons|app-manager|config|customizing|stylish-edit|downloads|permissions|preferences|sync-tabs|webrtc).*")

/*url-prefix("about:neterror")*/
/* url-prefix("about:"),   */

{

/*
 * Drop the below regex, after a comma, just before the opening curly bracket above, to exclude websites from solarization: 
 * ,regexp("https?://(www\.)?(?!(userstyles\.org|docs\.google|github)\..*).*")
 */


/* Firefox Scrollbars */
scrollbar {opacity: .75 !important;}

/*Vars
base03    #002b36 rgba(0,43,54,1);
base02    #073642 rgba(7,54,66,1);
base01    #586e75 rgba(88,110,117,1);
base00    #657b83 rgba(101,123,131,1);
base0     #839496 rgba(131,148,150,1);
base1     #93a1a1 rgba(147,161,161,1);
base2     #eee8d5 rgba(238,232,213,1);
base3     #fdf6e3 rgba(253,246,227,1);
yellow    #b58900 rgba(181,137,0,1);
orange    #cb4b16 rgba(203,75,22,1);
red       #dc322f rgba(220,50,47,1);
magenta   #d33682 rgba(211,54,130,1);
violet    #6c71c4 rgba(108,113,196,1);
blue      #268bd2 rgba(38,139,210,1);
cyan      #2aa198 rgba(42,161,152,1);
green     #859900 rgba(133,153,0,1);
*/

/* Base */
*, ::before, ::after {
color: #93a1a1 !important; 
border-color: #073642 !important;
outline-color: #073642 !important;
text-shadow: none !important;
box-shadow: none !important;
/*-moz-box-shadow: none !important;*/
background-color: transparent !important;
}

html * {
color: inherit !important;
}

p::first-letter,
h1::first-letter,
h2::first-letter,
p::first-line {

color: inherit !important; 
background: none !important;
}

/* :: Give solid BG :: */

/* element */
b,i,u,strong{color:#859900}


html, 
body,
li ul,
ul li,
table,
header,
article,
section,
nav,
menu,
aside,

/* common */

[class*="nav"],
[class*="open"],
[id*="ropdown"], /*dropdown*/
[class*="ropdown"], 
div[class*="menu"],
[class*="tooltip"],
div[class*="popup"], 
div[id*="popup"],

/* Notes, details, etc.  Maybe useful */
div[id*="detail"],div[class*="detail"],
div[class*="note"], span[class*="note"],
div[class*="description"],

/* Also common */
div[class*="content"], div[class*="container"],

/* Popup divs that use visibility: hidden and display: none */
div[style*="display: block"], 
div[style*="visibility: visible"] {
background-color: #002b36 !important
}



/*: No BG :*/
*:not(:empty):not(span):not([class="html5-volume-slider html5-draggable"]):not([class="html5-player-chrome html5-stop-propagation"]), *::before, *::after,
td:empty, p:empty, div:empty:not([role]):not([style*="flashblock"]):not([class^="html5"]):not([class*="noscriptPlaceholder"]) {
background-image: none !important;
}

/*: Filter non-icons :*/
span:not(:empty):not([class*="icon"]):not([id*="icon"]):not([class*="star"]):not([id*="star"]):not([id*="rating"]):not([class*="rating"]):not([class*="prite"]) {
background-image: none !important;
text-indent: 0 !important;
}

/*: Image opacity :*/
img, svg             {opacity: .75 !important;}
img:hover, svg:hover {opacity: 1 !important;}

/* Highlight */
::-moz-selection {
background-color: #eee8d5 !important;
color: #586e75 !important;
}

/* ::: anchor/links ::: */

a {
color: #2aa198 !important; 
background-color: #002b36 !important;
opacity: 1 !important; 
text-indent: 0 !important;
}

a:link         {color: #268bd2 !important;} /* hyperlink */
a:visited      {color: #6c71c4 !important;}
a:hover        {color: #b58900 !important; background-color: #073642 !important;}
a:active       {color: #cb4b16 !important;}

/* "Top level" div */

body > div {background-color: inherit !important;}

/* :::::: Text Presentation :::::: */

summary, details                   {background-color: inherit !important}
kbd, time, label, .date            {color: #859900 !important}
acronym, abbr                      {border-bottom: 1px dotted !important; cursor: help !important;}
mark						       {background-color: #dc322f !important}


/* :::::: Headings :::::: */

h1,h2,h3,h4,h5,h6  { 

background-image: none !important;
border-radius: 5px !important;
/*-moz-border-radius: 5px !important;*/
-webkit-border-radius: 5px !important; 
text-indent: 0 !important;
}

h1,h2,h3,h4,h5,h6 {background-color: #073642 !important}


h1,h2{color:#859900!important}
h3,h4{color:#b58900!important}
h5,h6{color:#cb4b16!important}

/* :::::: Tables, cells :::::: */

table table {background: #073642 !important;}
th, caption {background: #002b36 !important;}

/* ::: Inputs, textareas ::: */

input, textarea, button,
select,option,optgroup{

color: #586e75 !important;
background: none #073642 !important;
-moz-appearance: none !important; 
-webkit-appearance: none !important;
}

input,
textarea, 
button {
border-color: #586e75 !important; 
border-width: 1px !important;
}

/* :::::: Button styling :::::: */

input[type="button"],
input[type="submit"],
input[type="reset"],
button {
background: #073642 !important;
}

input[type="button"]:hover,
input[type="submit"]:hover,
input[type="reset"]:hover,
button:hover {
color: #586e75 !important;
background: #eee8d5 !important;
}

input[type="image"] {opacity: .85 !important}
input[type="image"]:hover {opacity: .95 !important}

/* Lightbox fix */
html [id*="lightbox"] * {background-color: transparent !important;}
html [id*="lightbox"] img {opacity: 1 !important;}

/* Youtube Annotation */
#movie_player-html5 .annotation {background: #073642 !important}

/* Mozilla addons shrink/expand sections */
.expando a {background: none transparent  !important;}

}


@-moz-document url(about:newtab) {

window {
background: #002b36 !important;
}

#newtab-scrollbox {
background: transparent none !important;
}

.newtab-title {
background-color: rgba(0,43,54,1) !important; 
color: #93a1a1 !important;
}

}

@-moz-document url(chrome://browser/content/browser.xul) {

/* Browser Background */
browser[type="content-primary"] {
background-color: #002b36 !important;
} 

}
