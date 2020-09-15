# Unity Package Sample

for Unity Package Manager's Package Sample

## Getting Started

### Prerequisites

- [Unity 2019.4.9f1](https://unity3d.com/jp/unity/whats-new/2019.4.9)



### Installing

Using [Unity Package Manager](https://docs.unity3d.com/2019.4/Documentation/Manual/Packages.html).



### Local File

1. Download this project.
2. Copy `Packages\murnana\package-sample` folder in your project.
3. Open your project's `./Packages/manifest.json` in text editor.
4. Add this package's url in your `manifest.json`. for example (if you copy for `<your-unity-project-path>/Packages/`.):
    ```json
    {
        "dependencies": {
            "com.murnana.package-sample": "file:./Packages/murnana/package-sample"
        }
    }
    ```
5. Open your project in Unity.

If you want more infomation, see [Unity User Manual > ... > Installing a package from a local folder](https://docs.unity3d.com/2019.4/Documentation/Manual/upm-ui-local.html) and (Unity User Manual > ... > Local folder or tarball paths)[https://docs.unity3d.com/2019.4/Documentation/Manual/upm-localpath.html]


### Using Git

1. Open `./Packages/manifest.json` in text editor.
2. Add this package's url in your `manifest.json`. for example:
    ```json
    {
        "dependencies": {
            "com.mycompany.mypackage": "https://github.com/murnana/Unity-PackagaeSample.git?path=/Packages/murnana/package-sample#develop"
        }
    }
    ```
3. Open your project in Unity.

If you want more infomation, see [Unity User Manual > ... > Installing from a Git URL](https://docs.unity3d.com/2019.4/Documentation/Manual/upm-ui-giturl.html) and (Unity User Manual > ... > Git dependencies)[https://docs.unity3d.com/2019.4/Documentation/Manual/upm-git.html]



## Versioning

We use [SemVer](http://semver.org/) for versioning because Unity Package Manager is use (see [Unity User Manual > ... > Versioning](https://docs.unity3d.com/2019.4/Documentation/Manual/upm-semver.html).). For the versions available, see the [tags on this repository](https://github.com/murnana/Unity-AnimationClip-Extention/tags). 


## Authors

* **murnana** - *Initial work* - [GitHub](https://github.com/murnana)

See also the list of [contributors](https://github.com/murnana/Unity-PackageSample/contributors) who participated in this project.



## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details



## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc
