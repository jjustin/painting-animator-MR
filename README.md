# Painting Animator in Mixed reality

This project holds Unity project that presents animations from [jjustin/paintings-animator](https://github.com/jjustin/paintings-animator) in Mixed Reality. Project is tested on Microsoft Hololens 2. But it should be able to run on any OpenXR compliant hardware.

Painting's vertices are deceted using original project's image detection algorthims on 2D plane. Each vertex is then transformed to 3D space based on the MR headset's spatial mapping. Calculated painting's 3D points are the used to render painting's animaition.

## More info

Code was written for and is further explained (in slovene) as part of [this bachelor's thesis](https://repozitorij.uni-lj.si/IzpisGradiva.php?id=139470)
