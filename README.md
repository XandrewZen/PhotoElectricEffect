# ⚡ PhotoElectricEffect

A Unity-based interactive simulation of the **Photoelectric Effect**, visualizing how electrons are emitted from a material when exposed to light of varying frequencies and voltage conditions.

## 📖 Description

This project simulates the fundamental principles of the photoelectric effect:

- Electrons are emitted from a metal surface when light with sufficient frequency hits it.
- The effect depends on the frequency of incident light and the voltage applied to the system.
- Users can control light frequency and battery voltage, affecting electron behavior.

This is designed for **educational purposes**, ideal for high school or undergraduate physics demonstrations.

## 🚀 Features

- 🌀 Electron emitter with adjustable density and randomness
- 🎛 Frequency and battery voltage controls
- ↔️ Electrons move forward; if energy insufficient, they return
- 💥 Visual indication of successful emission (or return)
- 🧠 Realistic logic: speed varies based on potential and frequency

## 🎮 Controls

| Parameter       | Description                                   |
|----------------|-----------------------------------------------|
| `frequency`     | Controls photon energy (higher = more energy) |
| `voltage`       | Controls the stopping potential (barrier)     |
| `density`       | Number of electrons spawned over time         |
| `maxDistance`   | Maximum distance an electron can travel       |

Adjust these via Unity Inspector or UI if available.

## 🛠 How to Use

1. Clone the repository:
   ```bash
   git clone https://github.com/XandrewZen/PhotoElectricEffect.git
