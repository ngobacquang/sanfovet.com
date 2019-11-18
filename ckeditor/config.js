/*
Copyright (c) 2003-2011, CKSource - Frederico Knabben. All rights reserved.
For licensing, see LICENSE.html or http://ckeditor.com/license
*/

CKEDITOR.editorConfig = function (config) {
    // Define changes to default configuration here. For example:
    CKEDITOR.config.toolbar_Max =
    [
        ['Source', '-', 'Save', 'NewPage', 'Preview', '-', 'Templates'],
        ['Cut', 'Copy', 'Paste', 'PasteText', 'PasteFromWord', '-', 'Print', 'SpellChecker', 'Scayt'],
        ['Undo', 'Redo', '-', 'Find', 'Replace', '-', 'SelectAll', 'RemoveFormat'],
        ['Form', 'Checkbox', 'Radio', 'TextField', 'Textarea', 'Select', 'Button', 'ImageButton', 'HiddenField'],        
        ['Bold', 'Italic', 'Underline', 'Strike', '-', 'Subscript', 'Superscript'],
        ['NumberedList', 'BulletedList', '-', 'Outdent', 'Indent', 'Blockquote', 'CreateDiv'],
        ['JustifyLeft', 'JustifyCenter', 'JustifyRight', 'JustifyBlock'],
        ['BidiLtr', 'BidiRtl'],
        ['Link', 'Unlink', 'Anchor'],
        ['Image', 'Flash', 'Table', 'HorizontalRule', 'Smiley', 'SpecialChar', 'PageBreak', 'Iframe'],        
        ['Styles', 'Format', 'Font', 'FontSize'],
        ['TextColor', 'BGColor'],
        ['Maximize', 'ShowBlocks', '-', 'About']
    ]

    CKEDITOR.config.toolbar_Standard =
    [
        ["Source", "-", "Preview"],
        ["JustifyLeft", "JustifyCenter", "JustifyRight", "JustifyBlock"],
        ["Bold", "Italic", "Underline", "Strike", "TextColor", "BGColor"],
        ["NumberedList", "BulletedList", "Outdent", "Indent"],
        ["Link", "Unlink"],
        ["Undo", "Redo", "Find", "Replace"],
        ["BidiLtr", "BidiRtl"],
        ["Image", "Flash", "MediaEmbed", "Youtube", "Iframe"],
        ["Table", "SpecialChar"],
        ["Styles", "Format", "Font", "FontSize"],
        ["ShowBlocks", "Maximize", "RemoveFormat"]
    ]

    CKEDITOR.config.toolbar_Basic =
    [
        ["JustifyLeft", "JustifyCenter", "JustifyRight", "JustifyBlock"],
        ["Bold", "Italic", "Underline", "Strike", "TextColor", "BGColor"],
        ["NumberedList", "BulletedList", "Outdent", "Indent"],
        ["Table", "SpecialChar"],
        ["Font", "FontSize"]
    ]

    CKEDITOR.config.toolbar_Min =
    [
        ["Bold", "Italic", "Underline", "Strike", "TextColor"],
        ["NumberedList", "BulletedList", "Outdent", "Indent"]
    ]

    //config.uiColor = '#DEDEDE';
    config.extraPlugins = 'youtube,MediaEmbed';
    //config.baseHref = 'http://localhost:59414/TatThanhCMS_V5.1/';

    
    config.language = 'vi';
    config.enterMode = CKEDITOR.ENTER_BR;
    config.shiftEnterMode = CKEDITOR.ENTER_P;
    config.height = '420';
    config.toolbar = 'Standard';


    config.filebrowserBrowseUrl = "ckeditor/ckfinder/ckfinder.aspx"
    config.filebrowserImageBrowseUrl = "ckeditor/ckfinder/ckfinder.aspx?type=Images"
    config.filebrowserFlashBrowseUrl = "ckeditor/ckfinder/ckfinder.aspx?type=Flash"
    config.filebrowserUploadUrl = "ckeditor/ckfinder/connector.aspx?command=QuickUpload&type=Files"
    config.filebrowserImageUploadUrl = "ckeditor/ckfinder/connector.aspx?command=QuickUpload&type=Images"
    config.filebrowserFlashUploadUrl = "ckeditor/ckfinder/connector.aspx?command=QuickUpload&type=Flash"
    
    //Giữ nguyên định dạng khi copy từ word
    config.pasteFromWordRemoveFontStyles = false;
    config.pasteFromWordRemoveStyles = false;
    config.pasteFromWordNumberedHeadingToList = true;
    config.pasteFromWordPromptCleanup = true;
};