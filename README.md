Milkman-Localization
====================

This repository is the open source home for Milkman's language translations. Milkman is the premier Remember The Milk client for the Windows Phone platform. Milkman currently supports French, German, Italian, Russian, and Spanish languages in addition to English. If you'd like to help translate Milkman for your own language, this is the place to do that.


Getting Started
---------------

Your contribution is essential to making Milkman a fully localized application. If you'd like to help translate Milkman for your own language, you can fork this repository, make your changes, and then submit a pull request on GitHub for review. After your change has been reviewed, it will be merged into the master branch and will be picked up in the next update to Milkman on the Windows Phone Store.

There are three main resources for Milkman that need to be translated: the application strings, the Marketplace descriptions, and the About page text. The application strings can be found in the root directory: `Strings.resx` is the default translation and `Strings.[es-ES].resx` is the translated file for the specified locale. The Marketplace descriptions can be found in the Marketplace directory: `Milkman.txt` is the default translation and `Milkman.[es-ES].txt` is the translated file for the specified locale. The About descriptions can be found in the About directory: `Data.xml` is the default translation and `Data.[es-ES].xml` is the translated file for the specified locale.

For more information about the ResX resource file format, see the Utilities section below.


Utilities
---------

Milkman uses the ResX resource file format for managing string translations. The ResX format consists of XML entries, which specify strings inside of XML tags. You can open thes files in any text editor to view their contents. 

You can also use the open-source the ResX Resource Manager tool to view these ResX files. This tool makes it easy to view all of Milkman's ResX files at once and helps identify which strings need to be translated when new ones are added. You can download this tool from CodePlex at http://resxresourcemanager.codeplex.com.


License
-------

This software, and its dependencies, are distributed free of charge and licensed under the MIT License. For more information about this license and the terms of use of this software, please review the LICENSE.txt file.

As a thank you for your help translating Milkman, your name will be featured on the About page for the application when viewed in your language.
