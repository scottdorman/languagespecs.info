# language-specs.info

This repository holds the web application code and data for the [Language Specs](http://www.languagespecs.info/) website.

## Background
As part of Microsoft's announcement of the [language strategy](https://blogs.msdn.microsoft.com/dotnet/2017/02/01/the-net-language-strategy/) for C#, VB, and F#, the language specs for [C#](https://github.com/dotnet/csharplang) and [VB](https://github.com/vblang) were made public in GitHub repositories.

This is actually really important for the language design process but it also allows anyone outside of Microsoft who is interested in reading (or even contributing to) the language specification to participate.

With that in mind, the [Language Specs website](http://www.languagespecs.info/) was created. This is your "one stop shop" for finding the language specs of your favorite programming language. The specs themselves aren't hosted here, that's still up to the individual language maintainers. Rather, this is, at it's heart, a collection of links to the official language spec for the respective language.

## Contributing
If you see something wrong with the site, need to correct the information about a spec, or want to add a spec that's missing, or want to contribute in some other way, simply [fork the repo](https://github.com/scottdorman/languagespecs.info/fork) and submit a pull request or [submit an issue](https://github.com/scottdorman/languagespecs.info/issues).

### Maintaining language spec data
All of the language spec data is in the [data subfolder](https://github.com/scottdorman/languagespecs.info/tree/master/src/LanguageSpecs.Web/wwwroot/data). The `specs.json` file is the actual data store. The format for a given language spec is

```json
{
    "title": "C#",
    "icon": "icon-prog-csharp",
    "logo": "typescript.jpg",
    "specUrl": "https://github.com/dotnet/csharplang"
}
```

The `icon` property is the name of the font icon in the [Pictonic Free](https://pictonic.co/free) set, if there is one available. If a font icon isn't available, the `logo` property should be used instead. This property is the name (with extension) of the appropriate logo image for the programming language, which should be located in the `images` subfolder. If both an `icon` and a `logo` are provided, the logo will be used. Images should be 60x60 if possible, but any image will end up being resized to 60x60 pixels.

The `title` is the text that will appear below the icon (or logo) and the `specUrl` is the actual URL to the official spec.

## Creators
* [Scott Dorman](http://scottdorman.azurewebsites.net) ([@sdorman](http://twitter.com/sdorman)) - for the initial concept and core contributor.

## Copyright and license
Code and documentation copyright 2017 Scott Dorman.