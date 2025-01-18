const WorkComments = [
  {
    company: 'Moss Kirkelige Fellesråd',
    comment:
      'Emil er en rolig og arbeidsom gutt. Han lærte oppgavene fort og jobbet selvstendig. Han lærte oppgavene raskt og jobbet godt.',
    author: 'Inger-Lise Klette',
  },
  {
    company: 'Specsavers',
    comment:
      'Emil er pliktoppfyllende og grundig. Han er en hyggelig kar som lærer raskt og har gjennomført de oppgaver han har fatt på en god måte den tiden han var her.',
    author: 'Bjørn Podhorny',
  },
];
function randomIndex() {
  return Math.floor(Math.random() * WorkComments.length);
}
export { WorkComments, randomIndex };
