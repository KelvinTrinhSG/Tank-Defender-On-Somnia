# 🛡️ Tank Defender – Web3 Unity Game on Somnia

**Tank Defender** is an attractive Unity game integrated with the **Somnia Testnet** using the **Thirdweb Unity SDK**. Players can enjoy an immersive Web3 gaming experience with full on-chain interactions including **claiming Gold tokens**, **buying/spending tokens**, **NFT gating**, and **saving/loading player progress** directly on the blockchain.

---

## 🎮 Gameplay Overview

Your mission is to defend against waves of monsters while managing your resources and leveling up. To access the full gameplay, players must hold a **Token Gate NFT**.

---

## 🚀 Features

- 🔐 **NFT Gating**: Players must hold the `GATE` NFT to play the game.
- 🎁 **Claim Gold (ERC20)**: Players can claim Gold to power up.
- 💎 **Buy GEM Tokens**: Additional GEM tokens can be bought to unlock more features.
- 🔄 **Spend Tokens**: Tokens are burned when spinning the Lucky Wheel.
- 🎡 **Lucky Wheel Spin**: Spend 1 token for a chance to win Gold.
- 💾 **Save & Load Level**: Player level is stored on-chain via custom smart contract.

---

## 🔗 Smart Contracts (Somnia Testnet)

| Contract            | Type   | Address                                                                                                                                    |
| ------------------- | ------ | ------------------------------------------------------------------------------------------------------------------------------------------ |
| Token Gate NFT      | ERC721 | [`0x9aEBF83Aa77dA3fcB451Da8C9dfcbE595f18feD2`](https://shannon-explorer.somnia.network/address/0x9aEBF83Aa77dA3fcB451Da8C9dfcbE595f18feD2) |
| Gold Token          | ERC20  | [`0x40D68BA05da78d2644aB831469CAa81A1EC71e66`](https://shannon-explorer.somnia.network/address/0x40D68BA05da78d2644aB831469CAa81A1EC71e66) |
| Gem Token           | ERC20  | [`0x74F411F2a3B0cAea8F256Ee735937978A6FE8c51`](https://shannon-explorer.somnia.network/address/0x74F411F2a3B0cAea8F256Ee735937978A6FE8c51) |
| Save Level Contract | Custom | [`0x579558E805cEf9374E5C75A45B989e38Eae4cA95`](https://shannon-explorer.somnia.network/address/0x579558E805cEf9374E5C75A45B989e38Eae4cA95) |

---

## 🧰 Tech Stack

- [Unity Engine](https://unity.com/)
- [Thirdweb Unity SDK](https://portal.thirdweb.com/unity)
- [Somnia Network](https://somnia.network/)
- [Thirdweb OpenEditionERC721 & DropERC20](https://thirdweb.com/)
- [Custom Smart Contract ABI (Save Level)](https://thirdweb.com/contracts/deploy/QmPTtWC4miXundtyaGqXRBGKkf2Pr8GYtu9m9tRtrchHfj)

---

## 🛠️ Setup Instructions

1. **Clone the repository**

   ```bash
   git clone https://github.com/KelvinTrinhSG/Tank-Defender-On-Somnia.git
   ```

2. **Open with Unity** (Recommended version: `2022.3.x` LTS)

3. **Install dependencies**

   - Import Thirdweb Unity SDK via Unity Package Manager.
   - Connect to Somnia Testnet using correct chain ID.

4. **Play the Game**
   - Press Play in Unity Editor
   - Click `Login`, mint the NFT, then start the game!

---

## 📷 Screenshots

![gameplay1](Assets/Screenshots/gameplay_1.png)
![gameplay2](Assets/Screenshots/gameplay_2.png)

---

## 🤝 Contributions

Contributions are welcome!  
Please open issues or pull requests for bugs, improvements, or new features.

---

## 📜 License

MIT License

---

## ✨ Credits

Created by [KelvinCOD](https://github.com/KelvinTrinhSG) and team.  
Powered by [Thirdweb](https://thirdweb.com/) and [Somnia](https://somnia.network/).

---
