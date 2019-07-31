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
          <Card icon={faBriefcase} title='Work Experience' sections={[{title: 'TDC', country:'Denmark', date: 'Feb 2018', content: 'I started working in TDC as a intern and later got employed as a full time employ. I learnet how to use React and been working with it for almost 2 years now. I worked in agile environment'},{title: 'GCF Consulting - Intership', date: 'Aug 2016 - Nov 2017', country:'Sweden', content: 'During my intership in GCF I created a webpage for the company and I got experiance working with my first client that wanted me to create a webpage for his pizzeria'}, {title: 'Epicode - Intership', content: 'During my intership at Epicode i leart how create responsive web application and i was mainly using Jquery', date: 'March 2014 - July 2014', country: 'Sweden'}]} />
          <Card icon={faGraduationCap} title='Education' sections={[{title: 'KYH Higher Vocational Education', country: 'Sweden', date: 'Feb 2016 - Fev 2018'}, {title: 'NTI Upper Secondary School', country: 'Sweden', date: 'Feb 2013 - Fev 2016'}]}/>
        </div>
      </main>
    </div>
  );
}

export default App;
