Milkman-Localization
====================

This repository is the open source home for Milkman's language translations. [Milkman](http://www.windowsphone.com/en-us/store/app/milkman/2d14a2ea-9445-4d46-b385-8b2e45f7f6d8) is the premier [Remember The Milk](http://www.rememberthemilk.com/) client for the [Windows Phone](http://www.windowsphone.com/) platform. Milkman currently supports French, German, Italian, Russian, and Spanish languages in addition to English. If you'd like to help translate Milkman for your own language, this is the place to do that.


Getting Started
---------------

Your contribution is essential to making Milkman a fully localized application. If you'd like to help translate Milkman for your own language, you can fork this repository, make your changes, and then submit a pull request on GitHub for review. After your change has been reviewed, it will be merged into the master branch and will be picked up in the next update to Milkman on the Windows Phone Store.

There are three main resources for Milkman that need to be translated: the application strings, the Marketplace descriptions, and the About page text. The application strings can be found in the root directory: `Strings.resx` is the default translation and `Strings.[es-ES].resx` is the translated file for the specified locale. The Marketplace descriptions can be found in the Marketplace directory: `Milkman.txt` is the default translation and `Milkman.[es-ES].txt` is the translated file for the specified locale. The About descriptions can be found in the About directory: `Data.xml` is the default translation and `Data.[es-ES].xml` is the translated file for the specified locale.

For more information about the ResX resource file format, see the Utilities section below.


Translations
------------

This section provides guidelines for translating Remember The Milk. If you have any questions about translations, please send an email to feedback@mbmccormick.com or visit the [Translation Guidelines](https://www.rememberthemilk.com/services/translate/guidelines.rtm) page on the Remember The Milk website.

#### Tone
Milkman in English is written in a friendly, casual style. You do not need to translate literally or word-for-word, but where possible please try to preserve a friendly tone with your translation.

#### Proper Names
Proper names or product names do not need to be translated. Examples of these include "Milkman" and "Remember The Milk".

#### Dates and Times
Please translate any examples of dates and times into your language (users will be able to enter due dates and other dates/times in their own language instead of English).

#### Corrections
Translating Milkman is a collaborative effort – several translators may work on the same language. To help ensure a consistent and high quality translation for each language, we encourage you to correct mistakes or offer improved translations. You can do this by choosing to edit existing translations, and providing a reason for your correction (we manually check corrections) in your commit message.


Utilities
---------

Milkman uses the [ResX resource file format](http://msdn.microsoft.com/en-us/library/ekyft91f(v=vs.90).aspx) for managing string translations. The ResX format consists of XML entries, which specify strings inside of XML tags. You can open thes files in any text editor to view their contents. 

You can also use the open-source [ResX Resource Manager](http://resxresourcemanager.codeplex.com) tool to view these ResX files. This tool makes it easy to view all of Milkman's ResX files at once and helps identify which strings need to be translated when new ones are added.


License
-------

This software, and its dependencies, are distributed free of charge and licensed under the MIT License. For more information about this license and the terms of use of this software, please review the LICENSE.txt file.

As a thank you for your help translating Milkman, your name will be featured on the About page for the application when viewed in your language.
