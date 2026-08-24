namespace Opgave02.model;

public class PotterNames
{
    public string fullName { get; set; }
    public string nickname { get; set; }
    public string hogwartsHouse { get; set; }
    public string interpretedBy { get; set; }
    public List<string> children { get; set; }
    public string image { get; set; }
    public string birthdate { get; set; }
    public int index { get; set; }

    
    public override string ToString()
    {
        return
            $"{nameof(fullName)}: {fullName}, {nameof(nickname)}: {nickname}, {nameof(hogwartsHouse)}: {hogwartsHouse}, {nameof(interpretedBy)}: {interpretedBy}, {nameof(children)}: {children}, {nameof(image)}: {image}, {nameof(birthdate)}: {birthdate}, {nameof(index)}: {index}";
    }
    
}



/*
    "fullName": "Harry James Potter",
    "nickname": "Harry",
    "hogwartsHouse": "Gryffindor",
    "interpretedBy": "Daniel Radcliffe",
    "children": [
        "James Sirius Potter",
        "Albus Severus Potter",
        "Lily Luna Potter"
    ],
    "image": "https://raw.githubusercontent.com/fedeperin/potterapi/main/public/images/characters/harry_potter.png",
    "birthdate": "Jul 31, 1980",
    "index": 0
*/