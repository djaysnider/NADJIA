# 🎧 N.A.D.J.I.A.

### *Networked Autonomous Disc Jockey and Improvisational Assistant*

![Build](https://img.shields.io/badge/build-probably%20works-some%20of%20the%20time-orange)
![Platform](https://img.shields.io/badge/platform-Windows%20%7C%20.NET-blue)
![Streaming](https://img.shields.io/badge/streaming-Shoutcast%20\(recovery%20in%20progress\)-purple)
![Philosophy](https://img.shields.io/badge/philosophy-vibes%20over%20rules-critical)
![License](https://img.shields.io/badge/license-TBD-lightgrey)

---

## 🧠 What is this?

First, there was **E.M.M.A.** (Enterprise Music Management Application), which was great but, let's face it, very turn-of-the-century.

<img width=100% alt="emma-screenshot" src="https://github.com/user-attachments/assets/8d0ffbb7-1a1a-4c62-a76c-a922a34d4289" />


Now there is, or ambitiously will one day be, **N.A.D.J.I.A.**, her big sister.  Like Emma, Nadjia plays music, manages streams, and
eventually—makes judgment calls about your programming choices like a slightly smug but well-informed co-host.

If traditional automation software is a spreadsheet with speakers, Nadjia is the person in the booth saying:

> “We *could* play that… or we could not embarrass ourselves.”

<img width=100% alt="nadjia-concept" src="https://github.com/user-attachments/assets/8ae310dc-f9ec-467a-823c-ae1c1b901f4e" />
<img width=100% alt="nadjia-concept2" src="https://github.com/user-attachments/assets/84bb8734-f6fd-40f7-b577-49ad45763e9c" />


---

## 🤨 Why does this exist?

Because the current ecosystem assumes one of the following:

* Emma's VB.NET over Microsoft Access codebase is part of her quirky charm
* You enjoy maintaining a fragile chain of legacy tools held together by DOS batch files and hope
* You think “random shuffle” is a programming strategy
* You’re okay with software that treats music like inventory

Nadjia exists because none of those are acceptable.

---

## ⚙️ Features

### 🎶 Playback Engine

* Playlist + rotation support
* Designed for *flow*, not just sequencing
* Future:

  * Energy/mood-aware transitions
  * Key/tempo alignment (when we feel like showing off)

---

### 📡 Streaming (Shoutcast and Beyond)

* Moving away from:

  * Winamp
  * DSP plugins from the Bush administration
* Toward:

  * Native streaming pipelines
  * Direct encoder control
  * Less suffering

---

### 🧠 Improvisational Layer

The reason this project exists.

* Detects when a set is:

  * Dragging
  * Repetitive
  * About to/Has already started to lose listeners
* Makes adjustments like:

  * Swapping tracks
  * Changing direction
  * Saving you from yourself

Not AI. Not random. Something more… *annoyingly perceptive*.

---

### 🌐 Network-Aware Architecture

* Remote libraries? Fine.
* Distributed components? Expected.
* Running half your station on another machine because you felt like it? Encouraged.

---

### 🏷 Metadata-Driven Decisions

* Uses ID3 tags like they actually matter
* Future direction:

  * Semantic grouping
  * “Vibe clustering”
  * The slow realization that your library says a lot about you

---

## 🚫 Non-Features

* Rigid corporate clock-wheel tyranny
* “Set it and forget it” boredom engines
* Pretending YAML is a personality

---

## 🛠 Installation

```bash
git clone https://github.com/djaysnider/nadjia.git
```

Then:

1. Open in **Visual Studio**
2. Build
3. Fix whatever breaks
4. Repeat until music happens

If it works on the first try, document nothing and walk away slowly.

---

## ▶️ Usage

Run it.

* If you hear music → success
* If you don’t → logs exist for a reason
* If it crashes → it’s expressing itself

---

## 🧱 Architecture (High-Level)

```text
[ Media Library ]
        ↓
[ Playback Engine ] ←→ [ Improvisation Layer ]
        ↓
[ Streaming / Encoder ]
        ↓
[ Internet / Listeners / Judgment ]
```

Everything important happens in the tension between **structure** and **improvisation**.

Too much structure = boring
Too much improvisation = chaos
Nadjia lives in the uncomfortable middle

---

## 🗺 Roadmap

* [ ] Native streaming (kill the Winamp dependency with fire)
* [ ] Intelligent playlist generation
* [ ] Real-time metrics that don’t require Excel therapy
* [ ] UI that doesn’t look like a DMV terminal
* [ ] Plugin architecture (so future-you can regret past-you properly)

---

## 🤝 Contributing

You might be a good fit if you:

* Care about how music *feels*, not just how it’s scheduled
* Have ever yelled at automation software
* Think “what if it just… knew better?”

PRs welcome. Opinions expected.

---

## ⚖️ License

TBD

Which currently means:

> “Don’t do anything weird until I decide.”

---

## 🧩 Final Thought

N.A.D.J.I.A. isn’t trying to replace radio.

It’s trying to remind it how to be interesting again.


