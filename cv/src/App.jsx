import React from 'react';
import Noman from './Noman.jpg'
import Card from './Card.jsx'
import SideBar from './Sidebar.jsx'
import { faBriefcase, faGraduationCap } from '@fortawesome/free-solid-svg-icons'

function App() {
  return (
    <div className="App">
      <header>
        <div>
          <h1 className='title'>Noman Lone</h1>
          <h3 className='subtitle'>Front-end Developer</h3>
        </div>
        <img className='portrait' src={Noman} alt="" />
      </header>
      <main>
        <SideBar />
        <div className='card-container'>
          <Card icon={faBriefcase} title='Work Experience' sections={[{title: 'TDC', country:'Denmark', date: 'Feb 2018'},{title: 'GCF Consulting', date: 'Aug 2016 - Nov 2017', country:'Sweden'}, {title: 'Epicode', date: 'March 2014 - July 2014', country: 'Sweden'}]} />
          <Card icon={faGraduationCap} title='Education' sections={[{title: 'KYH Higher Vocational Education', country: 'Sweden', date: 'Feb 2016 - Fev 2018'}, {title: 'NTI Upper Secondary School', country: 'Sweden', date: 'Feb 2013 - Fev 2016'}]}/>
        </div>
      </main>
    </div>
  );
}

export default App;
