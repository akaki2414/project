using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman {
    public class Game {
        public int Attempts { get; set; }
        public int Hints { get; set; }

        public List<string> HangmanWords= new List<string>
        {
            "Apple", "House", "Chair", "Ocean", "Table", "Shadow", "Winter", "Yellow", "Puzzle", "Rocket",
            "Thunder", "Whisper", "Journey", "Lantern", "Diamond", "Peacock", "Tropical", "Sandbox", "Kingdom", "Champion",
            "Elephant", "Festival", "Mountain", "Chimney", "Samurai", "Labyrinth", "Squirrel", "Architect", "Kangaroo", "Pyramid",
            "Avalanche", "Crocodile", "Orchestra", "Blueprint", "Dangerous", "Quarantine", "Chocolate", "Universe", "Zephyr", "Xylophone",
            "Bicycle", "Rainbow", "Penguin", "Giraffe", "Volcano", "Balloon", "Sunshine", "Notebook", "Firefly", "Treasure",
            "Backpack", "Stadium", "Satellite", "Compass", "Elephant", "Football", "Hospital", "Electric", "Cupcake", "Happiness",
            "Calendar", "Infinity", "Vacation", "Adventure", "Marathon", "Detective", "Bungalow", "Carousel", "Criminal", "Diamond",
            "Eclipse", "Forestry", "Gallery", "Harmony", "Illusion", "Jigsaw", "Knitting", "Landscape", "Magnolia", "Nightmare",
            "Oblivion", "Pandemic", "Quicksand", "Revolver", "Snowstorm", "Telescope", "Undertake", "Vanquish", "Waterfall", "Xenon",
            "Yielding", "Zodiac", "Accordion", "Blueprint", "Conductor", "Dolphin", "Evergreen", "Fireworks", "Gondola", "Hydrogen"
        };
    }
}
