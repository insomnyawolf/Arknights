# Arknights Re-Engraved

## Overview

This project is intended to rebuild [Arknights](https://arknights.global/ "Visit Arknights website") game from the sources provided by [Saukiya/Arknights](https://github.com/Saukiya/Arknights "Visit Saukiya Arknights repo").

The author is only providing the source code, so it's hard to make it work cause there's a bunch of missing assets & dependencies. Finally, I managed to resolve the missing dependencies so it's now a genuine Unity project, ready to be developed.

The missing dependencies are:

- [DOTween](https://dotween.demigiant.com "Visit DOTween website"): Animation/Tweening library.
- [spine-unity](http://en.esotericsoftware.com/spine-unity-download "Visit spine-unity website"): 2D skeletal animation library.
- [xLua](https://github.com/Tencent/xLua "Visit xLua repo"): Bring Lua programming into Unity.

[insomnyawolf](https://github.com/insomnyawolf/Arknights "Visit insomnyawolf Arknights repo") is already developing the project by refactoring and documenting the code base in these past year (2022), but still missing the dependencies, so it's hard to do trial and error. It maybe a great idea to collab and merge with this project.

To support this project, I store the game assets in [kiraio-moe/Arknights-Base](https://github.com/kiraio-moe/Arknights-Base "Visit Arknights-Base repo") that will be used in this project.

Curious what's the original author has achieved? [Watch the demo video](https://www.bilibili.com/video/BV15U4y1H7LX "Watch on bilibili").

## Contribute

Any contribution to this project is warmly welcome! Don't be shy..

## Notes

- Skeleton data asset (`.skel` file) from Arknights game is produced with Spine Editor v3.8.99 (last check on Arknights v14.0.01). So, you can only import it to Spine Editor v3.8.x and this project **must** be using [spine-unity](http://en.esotericsoftware.com/spine-unity-download "spine-unity") v3.8.x. Don't ever try to update spine-unity to the latest version, this will causing a 'ghost' Null Reference Exception error if you working with skeleton asset (See: ).

## Disclaimer

This project is intended only as educational purposes. Any game assets and resources related to Arknights used in this project is property and copyright of Hypergryph, Studio Montagne, Yostar.
