# tally-ncsu-viz


To do
- [x] Setup
  - [x] Create repo
  - [x] Create Unity project (2020.1.2f1)
- [ ] Feed data setup
  - [x] Update API with basic feed data
  - [x] Get Feed data in Unity
  - [x] Convert Feed data to JSON object
  - [ ] Update API with detailed feed data
  - [ ] Build Feed data testing / monitor UI
  - [x] Create EventManager
- [ ] Timeline
  - [x] Time UI class
    - [ ] Button: Change refresh time
    - [ ] Button: playback restart
    - [ ] Scrubber: playback speed
  - [ ] Create playback 
    - [ ] Coroutine to play event at specific time
- [ ] Visuals -> Monsters
  - [x] Create addressables system for sprite animation slicing workflow
  - [x] Create MonsterPool
   - [ ] Create add / subtract from pool methods
- [ ] Visuals -> Players
  - [ ] Initialize
    - [ ] Use Feed data to build GameObjects and display in "Universe"
  - [ ] Player -> Actions 👈 
    - [ ] Create a series of actions (physics controlled from methods) that visualize different event types on playback
      - [ ] Stream
        - [ ] Click 
          - Player movement: velocity and Y position increases, random X direction
          - Sound: ping
          - Animation: expanding concentric rings similar to "[radar](https://www.provideocoalition.com/wp-content/uploads/Radar.gif)" effect but with better colors
        - [ ] Like
          - Player movement: ?
          - Sound: ?
          - Animation: ?
      - [ ] Attack
        - [ ] Awarded
          - Player movement: ?
          - Sound: ?
          - Animation: ?
      - [ ] Badge
        - [ ] Awarded (changes depending level)
          - Player movement: ?
          - Sound: ?
          - Animation: ?
      - [ ] Consumable
        - [ ] Found (changes depending type, stat)
          - Player movement: ?
          - Sound: ?
          - Animation: ?
      - [ ] Disguise
        - [ ] Awarded
          - Player movement: ?
          - Sound: ?
          - Animation: ?
      - [ ] Tracker
        - [ ] Blocked
          - Player movement: ?
          - Sound: ?
          - Animation: ? 
      - [ ] Battle
        - [] In-progress
          - Player movement: ?
          - Sound: Light battle music (on zoomed in)
          - Animations: Rumble animation appears over player
        - [ ] Attack
          - Player movement: ?
          - Sound: ?
          - Animation: Attack animation GIF
        - [ ] Win 
          - Player movement: ?
          - Sound: ?
          - Animation: Show win screen from game
        - [ ] Lost
          - Player movement: ?
          - Sound: ?
          - Animation: ? 
      - [ ] Leaderboard
        - [ ] Position in leaderboard changes
          - Player movement: ?
          - Sound: ?
          - Animation: ?   
  - [ ] User -> Movement 👈 
    - [ ] Create user (physics controlled) floating movement (Jellyfish?)
  - [ ] User -> Trails 👈 
    - [ ] Create "Nyan Cat" trails (particle system?)
      - [ ] Each trail is a product marketing category from streams
      - [ ] [Colors](https://github.com/sneakaway-studio/tally-api/blob/master/public/assets/css/sass/custom.scss)
      - [ ] Add/remove monsters from data trail based on streams updates
- [ ] Visuals -> Environment
  - [ ] Particles 👈
    - [ ] Use particle system to create small floating objects to give the visual display depth
      - [ ] Snow similar to the [upside down](https://www.youtube.com/watch?v=LwmnNzY7gdo&ab_channel=AmbientWorlds) floaty bits
      - [ ] Detritus in undersea life a.k.a "[marine snow](https://oceanservice.noaa.gov/facts/marinesnow.html)"
      - [ ] [Stars in cosmos](https://penningdownheart.files.wordpress.com/2018/03/stars-3000x2000-purple-cosmos-hd-7172.jpg)
  - [ ] Lighting 👈
    - [ ] Point lights on GameObjects
    - [ ] Environmental lighting
    - [ ] Changes to lighting depending on time of day
    - [ ] Baking, etc. performance considerations
  - [ ] Background
- [ ] Test in space
  - [ ] 8 cameras
  - [ ] Figure out user control device
