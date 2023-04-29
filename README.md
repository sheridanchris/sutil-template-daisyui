## Sutil Template for DaisyUI

```shell
git clone https://github.com/sheridanchris/sutil-template-daisyui
cd sutil-template-daisyui
npm install
npm start
```

For the best experience, and to minimize the chance of specifying incorrect class names, install
the Tailwind CSS IntelliSense plugin (for VSCode). Add the following to `settings.json`:

```json
"tailwindCSS.experimental.classRegex": [
    "Attr\\.className\\s+\"([^\"]*)\"",
    "Html\\.divc\\s+\"([^\"]*)\"",
    "class'\\s+\"([^\"]*)\""
],
"tailwindCSS.includeLanguages": {
    "fsharp": "html"
}
```
