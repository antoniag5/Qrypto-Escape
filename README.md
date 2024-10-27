# Qrypto-Escape

This Unity-based project introduces players to quantum cryptography concepts in an escape-room-style setting. Players interact with components on an optical table to simulate quantum measurements as part of the BB84 protocol, building a shared secret key to escape the room. This game was developed for QPoland's Quantum Hackathon 2024 and provides an immersive way to learn about quantum key distribution and quantum mechanics concepts. The idea came from laboratory demonstration of the BB84 protocol with optomechanical components from Thorlabs. We explored the idea of using a digital twin of the actual experimental photonics setup in an educational game.

## Game Overview

In this escape room game, players embody Beatrice a quantum cryptographer. Beatrice wakes up, feeling dizzy, in a disorganized quantum cryptography lab. Something has gone wrong — the lab is in lockdown, and vital components needed for quantum communication are scattered. She receives a faint classical signal from her colleague Albert outside: “Beatrice, listen carefully. Eve is trying to intercept our data. You need to find the components, set up the optical table, and establish a secure quantum connection using the BB84 protocol before it’s too late. I’ll guide you, but we have to move fast.” Beatrice must now gather her wits, search for the missing optical components, and receive guidance from Albert through the classical channel to build the setup, perform the quantum key distribution protocol to receive a random key and then decrypt the encrypted password and and escape the room. Are they safe or more dangers wait ahead?

## Installation and Setup

1. Get the game from repository: https://github.com/antoniag5/Qrypto-Escape , or play on itch.io: https://rishigames.itch.io/qrypto-escape

2. Unzip Build.zip and open the lvl3-fix.exe file!

TIPS FOR THE GAME: In the first scene, gather at least 3 parts of the receiver to move on to the next scene. HINT: One part is not like the others!
                   In the second scene, drag and drop the plate until you see a photon passing through.
### Scene 1: Search room and find components

In this phase, Beatrice explores the lab to locate essential quantum components, including:

Single Photon Source
Half-Wave Plate (HWP) for Alice
Half-Wave Plate (HWP) for Bob
Polarizing Beam Splitter (PBS)
Single Photon Detectors (0 and 1)
Once all items are collected, she must assemble them correctly on an optical table, guided by Albert over the classical channel. The environment encourages exploration, with small clues scattered to help players understand the components' functions.

### Scene 2: Build and use optical table for BB84 QKD protocol

In the second scene, Beatrice assembles the optical table by dragging and dropping the components into their respective positions. Once the setup is complete, the BB84 minigame is initiated:

Photon Measurement: Beatrice selects a basis (either + or x) for each incoming photon to measure, or lets the game select randomly. The path each photon takes through the setup (to either Detector0 or Detector1) determines whether a 0 or 1 is added to the key.
Key Matching: Beatrice and Albert compare their bases to keep only the measurements where they matched, forming a shared secret key.
Eve’s Presence: There is always a possibility Eve is trying to measure the photon Albert is sending. But due to the quantum no cloning theory the interception can be discovered in the quantum channel.

### Scene 3: Decode password and escape room.

With the key generated, Beatrice uses a one-time pad to decrypt a final password Albert has sent. Entering this password on the lab’s main control terminal opens the locked door, allowing her to escape. However, cryptic messages suggest further challenges lie ahead...

## Contributors

Antonia Giannoulea - Game Mechanics, Scene Design
Rishi Tiwari - Game Mechanics, Scene Design
Ioannis Theodonis - Game Concept & Quantum Cryptography Expertise

## License

This project is licensed under the MIT License
